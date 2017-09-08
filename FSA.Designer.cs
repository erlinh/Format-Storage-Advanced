namespace Format_Storage_Advanced
{
    partial class FSA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSA));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_valumelabel = new System.Windows.Forms.TextBox();
            this.quickFormatCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_fs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.startFormat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_devicename = new System.Windows.Forms.ComboBox();
            this.groupBox_Info = new System.Windows.Forms.GroupBox();
            this.freespace_label = new System.Windows.Forms.Label();
            this.totalspace_label = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.info_rootdir = new System.Windows.Forms.Label();
            this.info_driveformat = new System.Windows.Forms.Label();
            this.info_drivetype = new System.Windows.Forms.Label();
            this.info_vollabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.formattingstatus = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(281, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // textBox_valumelabel
            // 
            this.textBox_valumelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_valumelabel.Location = new System.Drawing.Point(12, 155);
            this.textBox_valumelabel.Name = "textBox_valumelabel";
            this.textBox_valumelabel.Size = new System.Drawing.Size(256, 20);
            this.textBox_valumelabel.TabIndex = 6;
            this.textBox_valumelabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_valumelabel_KeyPress);
            // 
            // quickFormatCheckbox
            // 
            this.quickFormatCheckbox.AutoSize = true;
            this.quickFormatCheckbox.Checked = true;
            this.quickFormatCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.quickFormatCheckbox.Location = new System.Drawing.Point(6, 19);
            this.quickFormatCheckbox.Name = "quickFormatCheckbox";
            this.quickFormatCheckbox.Size = new System.Drawing.Size(86, 17);
            this.quickFormatCheckbox.TabIndex = 7;
            this.quickFormatCheckbox.Text = "Quick format";
            this.quickFormatCheckbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.quickFormatCheckbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 61);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Format options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "File system:";
            // 
            // comboBox_fs
            // 
            this.comboBox_fs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_fs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_fs.FormattingEnabled = true;
            this.comboBox_fs.Location = new System.Drawing.Point(12, 115);
            this.comboBox_fs.Name = "comboBox_fs";
            this.comboBox_fs.Size = new System.Drawing.Size(256, 21);
            this.comboBox_fs.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Volume label";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(193, 396);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // startFormat
            // 
            this.startFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startFormat.Location = new System.Drawing.Point(112, 396);
            this.startFormat.Name = "startFormat";
            this.startFormat.Size = new System.Drawing.Size(75, 23);
            this.startFormat.TabIndex = 16;
            this.startFormat.Text = "Start";
            this.startFormat.UseVisualStyleBackColor = true;
            this.startFormat.Click += new System.EventHandler(this.startFormat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Device";
            // 
            // comboBox_devicename
            // 
            this.comboBox_devicename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_devicename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_devicename.FormattingEnabled = true;
            this.comboBox_devicename.Location = new System.Drawing.Point(12, 43);
            this.comboBox_devicename.Name = "comboBox_devicename";
            this.comboBox_devicename.Size = new System.Drawing.Size(256, 21);
            this.comboBox_devicename.TabIndex = 17;
            this.comboBox_devicename.SelectedIndexChanged += new System.EventHandler(this.comboBox_devicename_SelectedIndexChanged);
            // 
            // groupBox_Info
            // 
            this.groupBox_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Info.Controls.Add(this.freespace_label);
            this.groupBox_Info.Controls.Add(this.totalspace_label);
            this.groupBox_Info.Controls.Add(this.label11);
            this.groupBox_Info.Controls.Add(this.label10);
            this.groupBox_Info.Controls.Add(this.info_rootdir);
            this.groupBox_Info.Controls.Add(this.info_driveformat);
            this.groupBox_Info.Controls.Add(this.info_drivetype);
            this.groupBox_Info.Controls.Add(this.info_vollabel);
            this.groupBox_Info.Controls.Add(this.label9);
            this.groupBox_Info.Controls.Add(this.label8);
            this.groupBox_Info.Controls.Add(this.label7);
            this.groupBox_Info.Controls.Add(this.label6);
            this.groupBox_Info.Location = new System.Drawing.Point(12, 259);
            this.groupBox_Info.Name = "groupBox_Info";
            this.groupBox_Info.Size = new System.Drawing.Size(256, 116);
            this.groupBox_Info.TabIndex = 19;
            this.groupBox_Info.TabStop = false;
            this.groupBox_Info.Text = "Drive Info";
            // 
            // freespace_label
            // 
            this.freespace_label.AutoSize = true;
            this.freespace_label.Location = new System.Drawing.Point(81, 80);
            this.freespace_label.Name = "freespace_label";
            this.freespace_label.Size = new System.Drawing.Size(0, 13);
            this.freespace_label.TabIndex = 31;
            // 
            // totalspace_label
            // 
            this.totalspace_label.AutoSize = true;
            this.totalspace_label.Location = new System.Drawing.Point(81, 67);
            this.totalspace_label.Name = "totalspace_label";
            this.totalspace_label.Size = new System.Drawing.Size(0, 13);
            this.totalspace_label.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Free Space";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Total Space";
            // 
            // info_rootdir
            // 
            this.info_rootdir.AutoSize = true;
            this.info_rootdir.Location = new System.Drawing.Point(78, 55);
            this.info_rootdir.Name = "info_rootdir";
            this.info_rootdir.Size = new System.Drawing.Size(0, 13);
            this.info_rootdir.TabIndex = 27;
            // 
            // info_driveformat
            // 
            this.info_driveformat.AutoSize = true;
            this.info_driveformat.Location = new System.Drawing.Point(78, 42);
            this.info_driveformat.Name = "info_driveformat";
            this.info_driveformat.Size = new System.Drawing.Size(0, 13);
            this.info_driveformat.TabIndex = 26;
            // 
            // info_drivetype
            // 
            this.info_drivetype.AutoSize = true;
            this.info_drivetype.Location = new System.Drawing.Point(78, 29);
            this.info_drivetype.Name = "info_drivetype";
            this.info_drivetype.Size = new System.Drawing.Size(0, 13);
            this.info_drivetype.TabIndex = 25;
            // 
            // info_vollabel
            // 
            this.info_vollabel.AutoSize = true;
            this.info_vollabel.Location = new System.Drawing.Point(78, 16);
            this.info_vollabel.Name = "info_vollabel";
            this.info_vollabel.Size = new System.Drawing.Size(0, 13);
            this.info_vollabel.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Root directory";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Drive format";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Drive type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Volume label";
            // 
            // formattingstatus
            // 
            this.formattingstatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formattingstatus.AutoSize = true;
            this.formattingstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formattingstatus.Location = new System.Drawing.Point(14, 444);
            this.formattingstatus.Name = "formattingstatus";
            this.formattingstatus.Size = new System.Drawing.Size(0, 20);
            this.formattingstatus.TabIndex = 22;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Location = new System.Drawing.Point(193, 70);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 23;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(29, 396);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 24;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // FSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 474);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.formattingstatus);
            this.Controls.Add(this.groupBox_Info);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_devicename);
            this.Controls.Add(this.startFormat);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_fs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_valumelabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(195, 495);
            this.Name = "FSA";
            this.Text = "Format Storage Advanced";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Info.ResumeLayout(false);
            this.groupBox_Info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_valumelabel;
        private System.Windows.Forms.CheckBox quickFormatCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_fs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button startFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_devicename;
        private System.Windows.Forms.GroupBox groupBox_Info;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label info_rootdir;
        private System.Windows.Forms.Label info_driveformat;
        private System.Windows.Forms.Label info_drivetype;
        private System.Windows.Forms.Label info_vollabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label formattingstatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label freespace_label;
        private System.Windows.Forms.Label totalspace_label;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

