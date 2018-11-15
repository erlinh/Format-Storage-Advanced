using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Format_Storage_Advanced
{
    public partial class FSA : Form
    {
        public FSA()
        {
            InitializeComponent();

            getDeviceList();
        }
        string request, strName;
        Process formatProcess = new Process();

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void openAboutPage_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();

        }

        private void startFormat_Click(object sender, EventArgs e)
        {
            if (comboBox_devicename.SelectedItem == null)
            {
                MessageBox.Show("Select drive first!");
                return;
            }
            string driveName = (comboBox_devicename.SelectedItem).ToString().Replace("\\", "");
            var newLabel = textBox_valumelabel.Text;
            string fileSystemFormat = comboBox_fs.SelectedItem.ToString();

            DriveInfo SelectedDrive = new DriveInfo(comboBox_devicename.Text);
            if (MessageBox.Show("You want to format really?", "Info", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                strName = textBox_valumelabel.Text.Trim();
                //check if quick format checkbox is checked
                if (quickFormatCheckbox.Checked == false)
                {
                    request = "Format /v:" + strName + " /FS:" + fileSystemFormat + " /x /backup " + SelectedDrive.Name.Replace("\\", " ");
                }
                else
                {
                    request = "Format /v:" + strName + " /FS:" + fileSystemFormat + " /x /Q /backup " + SelectedDrive.Name.Replace("\\", " ");
                }
                    cancelButton.Enabled = true;
                    formatProcess.StartInfo.RedirectStandardOutput = true;
                    formatProcess.StartInfo.RedirectStandardError = true;
                    formatProcess.StartInfo.CreateNoWindow = true;
                    formatProcess.StartInfo.UseShellExecute = false;
                    //this try statement is here to avoid the application to crash,
                    //when the is not enough space, read-only location
                try
                    {
                        File.WriteAllText("batman.bat", request + Environment.NewLine);
                    }
                    catch (IOException m)
                    {
                        MessageBox.Show(m.Message.ToString());
                        startFormat.Enabled = true;
                        return;
                    }
                    formatProcess.StartInfo.FileName = "batman.bat";
                    //START the process
                    formatProcess.Start();
                    while (!formatProcess.HasExited)
                    {
                        formattingstatus.Text = "Formatting, processes left.";
                    }
                    formattingstatus.Text = "";
                if (formatProcess.HasExited)
                {
                    MessageBox.Show("Done!");
                }
            }

            formattingstatus.Text = "";
            startFormat.Enabled = true;
            
            cancelButton.Enabled = false;
        }

        public void getDeviceList(){
            //Clear all drives from the combobox
            comboBox_fs.Items.Clear();
            comboBox_devicename.Items.Clear();
            //Get list of drives
            var driveList = DriveInfo.GetDrives();
            int i = 0;
            foreach (DriveInfo drive in driveList)
            {
                //Only removeable devices
                if (drive.DriveType == DriveType.Removable)
                {
                    comboBox_devicename.Items.Insert(i, drive.Name);
                    i++;
                }
            }

            //Add FAT32 and exFAT to filesystem options
            comboBox_fs.Items.Insert(0, "FAT32");
            comboBox_fs.Items.Insert(1, "exFAT");

            //Clear label input and info
            textBox_valumelabel.Text = "";
            info_drivetype.Text = "";
            info_rootdir.Text = "";
            info_driveformat.Text = "";
            info_vollabel.Text = "";
            totalspace_label.Text = "";
            freespace_label.Text = "";

            //Disable formatting
            startFormat.Enabled = false;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            getDeviceList();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            formatProcess.Close();
            formatProcess.Dispose();
        }

        private void textBox_valumelabel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ') e.Handled = true;
        }

        private void comboBox_devicename_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox_devicename.SelectedIndex;

            var driveList = DriveInfo.GetDrives();
            foreach (DriveInfo drive in driveList)
            {
                if (drive.DriveType == DriveType.Removable && drive.Name == comboBox_devicename.Text)
                {
                    comboBox_fs.SelectedIndex = 0;

                    //Enable formatting
                    startFormat.Enabled = true;

                    //Catching errors in case of corrupt drive
                    try
                    {
                    //Autofill the label input
                    textBox_valumelabel.Text = drive.VolumeLabel;

                    //Drive info
                    info_drivetype.Text = drive.DriveType.ToString();
                    info_rootdir.Text = drive.RootDirectory.FullName;
                    info_driveformat.Text = drive.DriveFormat;
                    info_vollabel.Text = drive.VolumeLabel;
                    totalspace_label.Text = ((drive.TotalSize / 1024f) / 1024f).ToString() + "MB";
                    freespace_label.Text = ((drive.AvailableFreeSpace / 1024f) / 1024f).ToString() + "MB";

                    }
                    catch
                    {

                    }

                }
            }

        }
    }
}
