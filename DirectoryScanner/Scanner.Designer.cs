using System.Windows.Forms;

namespace DirectoryScanner
{
    partial class Scanner
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
            this.pnlLeftNav = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnScanner = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOnlyCheck = new System.Windows.Forms.TextBox();
            this.lblSettingsTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSettingsMSPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSettingsMSUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSettingsMSHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSettingsEmailFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSettingsEmailTo = new System.Windows.Forms.TextBox();
            this.btnSettingsLogLocation = new System.Windows.Forms.Button();
            this.lblSettingsLogLocation = new System.Windows.Forms.Label();
            this.tbSettingsLogLocation = new System.Windows.Forms.TextBox();
            this.btnSettingsDirectory = new System.Windows.Forms.Button();
            this.lblSettingsDirectory = new System.Windows.Forms.Label();
            this.tbSettingsDirectory = new System.Windows.Forms.TextBox();
            this.btnSettingsSave = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbDirectory = new System.Windows.Forms.TextBox();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.tbLogDirectory = new System.Windows.Forms.TextBox();
            this.btnLogDirectory = new System.Windows.Forms.Button();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.lblLogLocation = new System.Windows.Forms.Label();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cbUseLastRun = new System.Windows.Forms.CheckBox();
            this.lblCMS = new System.Windows.Forms.Label();
            this.datepicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOnlyCheckDir = new System.Windows.Forms.TextBox();
            this.pnlLeftNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftNav
            // 
            this.pnlLeftNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.pnlLeftNav.Controls.Add(this.btnSettings);
            this.pnlLeftNav.Controls.Add(this.btnScanner);
            this.pnlLeftNav.Controls.Add(this.picLogo);
            this.pnlLeftNav.Location = new System.Drawing.Point(-8, 0);
            this.pnlLeftNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeftNav.Name = "pnlLeftNav";
            this.pnlLeftNav.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.pnlLeftNav.Size = new System.Drawing.Size(285, 580);
            this.pnlLeftNav.TabIndex = 7;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Leelawadee UI", 11F);
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = global::DirectoryScanner.Properties.Resources.settings;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 163);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(285, 52);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnScanner
            // 
            this.btnScanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.btnScanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScanner.FlatAppearance.BorderSize = 0;
            this.btnScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanner.Font = new System.Drawing.Font("Leelawadee UI", 11F);
            this.btnScanner.ForeColor = System.Drawing.Color.White;
            this.btnScanner.Image = global::DirectoryScanner.Properties.Resources.scanner;
            this.btnScanner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanner.Location = new System.Drawing.Point(0, 111);
            this.btnScanner.Margin = new System.Windows.Forms.Padding(4);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnScanner.Size = new System.Drawing.Size(285, 52);
            this.btnScanner.TabIndex = 2;
            this.btnScanner.Text = "Scanner";
            this.btnScanner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScanner.UseVisualStyleBackColor = false;
            this.btnScanner.Click += new System.EventHandler(this.btnScanner_Click);
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Image = global::DirectoryScanner.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(285, 111);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.pnlTop.Controls.Add(this.btnAbout);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1069, 55);
            this.pnlTop.TabIndex = 1;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(56)))));
            this.btnAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Leelawadee UI", 11F);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = global::DirectoryScanner.Properties.Resources.help;
            this.btnAbout.Location = new System.Drawing.Point(1010, -3);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(59, 57);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Visible = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.label7);
            this.pnlSettings.Controls.Add(this.tbOnlyCheckDir);
            this.pnlSettings.Controls.Add(this.label6);
            this.pnlSettings.Controls.Add(this.tbOnlyCheck);
            this.pnlSettings.Controls.Add(this.lblSettingsTitle);
            this.pnlSettings.Controls.Add(this.label5);
            this.pnlSettings.Controls.Add(this.tbSettingsMSPassword);
            this.pnlSettings.Controls.Add(this.label3);
            this.pnlSettings.Controls.Add(this.tbSettingsMSUsername);
            this.pnlSettings.Controls.Add(this.label4);
            this.pnlSettings.Controls.Add(this.tbSettingsMSHost);
            this.pnlSettings.Controls.Add(this.label1);
            this.pnlSettings.Controls.Add(this.tbSettingsEmailFrom);
            this.pnlSettings.Controls.Add(this.label2);
            this.pnlSettings.Controls.Add(this.tbSettingsEmailTo);
            this.pnlSettings.Controls.Add(this.btnSettingsLogLocation);
            this.pnlSettings.Controls.Add(this.lblSettingsLogLocation);
            this.pnlSettings.Controls.Add(this.tbSettingsLogLocation);
            this.pnlSettings.Controls.Add(this.btnSettingsDirectory);
            this.pnlSettings.Controls.Add(this.lblSettingsDirectory);
            this.pnlSettings.Controls.Add(this.tbSettingsDirectory);
            this.pnlSettings.Controls.Add(this.btnSettingsSave);
            this.pnlSettings.Location = new System.Drawing.Point(277, 52);
            this.pnlSettings.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(792, 528);
            this.pnlSettings.TabIndex = 7;
            this.pnlSettings.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Only Check (File)";
            // 
            // tbOnlyCheck
            // 
            this.tbOnlyCheck.Location = new System.Drawing.Point(180, 146);
            this.tbOnlyCheck.Name = "tbOnlyCheck";
            this.tbOnlyCheck.Size = new System.Drawing.Size(491, 22);
            this.tbOnlyCheck.TabIndex = 19;
            // 
            // lblSettingsTitle
            // 
            this.lblSettingsTitle.AutoSize = true;
            this.lblSettingsTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsTitle.Location = new System.Drawing.Point(20, 19);
            this.lblSettingsTitle.Name = "lblSettingsTitle";
            this.lblSettingsTitle.Size = new System.Drawing.Size(209, 32);
            this.lblSettingsTitle.TabIndex = 18;
            this.lblSettingsTitle.Text = "Set Default Values";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mail Server Password";
            // 
            // tbSettingsMSPassword
            // 
            this.tbSettingsMSPassword.Location = new System.Drawing.Point(180, 420);
            this.tbSettingsMSPassword.Name = "tbSettingsMSPassword";
            this.tbSettingsMSPassword.Size = new System.Drawing.Size(491, 22);
            this.tbSettingsMSPassword.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mail Server Username";
            // 
            // tbSettingsMSUsername
            // 
            this.tbSettingsMSUsername.Location = new System.Drawing.Point(180, 381);
            this.tbSettingsMSUsername.Name = "tbSettingsMSUsername";
            this.tbSettingsMSUsername.Size = new System.Drawing.Size(491, 22);
            this.tbSettingsMSUsername.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Mail Server Host";
            // 
            // tbSettingsMSHost
            // 
            this.tbSettingsMSHost.Location = new System.Drawing.Point(180, 340);
            this.tbSettingsMSHost.Name = "tbSettingsMSHost";
            this.tbSettingsMSHost.Size = new System.Drawing.Size(491, 22);
            this.tbSettingsMSHost.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email From";
            // 
            // tbSettingsEmailFrom
            // 
            this.tbSettingsEmailFrom.Location = new System.Drawing.Point(180, 299);
            this.tbSettingsEmailFrom.Name = "tbSettingsEmailFrom";
            this.tbSettingsEmailFrom.Size = new System.Drawing.Size(491, 22);
            this.tbSettingsEmailFrom.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email To";
            // 
            // tbSettingsEmailTo
            // 
            this.tbSettingsEmailTo.Location = new System.Drawing.Point(180, 258);
            this.tbSettingsEmailTo.Name = "tbSettingsEmailTo";
            this.tbSettingsEmailTo.Size = new System.Drawing.Size(491, 22);
            this.tbSettingsEmailTo.TabIndex = 7;
            // 
            // btnSettingsLogLocation
            // 
            this.btnSettingsLogLocation.Location = new System.Drawing.Point(679, 103);
            this.btnSettingsLogLocation.Name = "btnSettingsLogLocation";
            this.btnSettingsLogLocation.Size = new System.Drawing.Size(101, 27);
            this.btnSettingsLogLocation.TabIndex = 6;
            this.btnSettingsLogLocation.Text = "Browse";
            this.btnSettingsLogLocation.UseVisualStyleBackColor = true;
            this.btnSettingsLogLocation.Click += new System.EventHandler(this.btnSettingsLogLocation_Click);
            // 
            // lblSettingsLogLocation
            // 
            this.lblSettingsLogLocation.AutoSize = true;
            this.lblSettingsLogLocation.Location = new System.Drawing.Point(17, 111);
            this.lblSettingsLogLocation.Name = "lblSettingsLogLocation";
            this.lblSettingsLogLocation.Size = new System.Drawing.Size(90, 17);
            this.lblSettingsLogLocation.TabIndex = 5;
            this.lblSettingsLogLocation.Text = "Log Location";
            // 
            // tbSettingsLogLocation
            // 
            this.tbSettingsLogLocation.Location = new System.Drawing.Point(180, 106);
            this.tbSettingsLogLocation.Name = "tbSettingsLogLocation";
            this.tbSettingsLogLocation.Size = new System.Drawing.Size(491, 22);
            this.tbSettingsLogLocation.TabIndex = 4;
            // 
            // btnSettingsDirectory
            // 
            this.btnSettingsDirectory.Location = new System.Drawing.Point(679, 62);
            this.btnSettingsDirectory.Name = "btnSettingsDirectory";
            this.btnSettingsDirectory.Size = new System.Drawing.Size(101, 27);
            this.btnSettingsDirectory.TabIndex = 3;
            this.btnSettingsDirectory.Text = "Browse";
            this.btnSettingsDirectory.UseVisualStyleBackColor = true;
            this.btnSettingsDirectory.Click += new System.EventHandler(this.btnSettingsDirectory_Click);
            // 
            // lblSettingsDirectory
            // 
            this.lblSettingsDirectory.AutoSize = true;
            this.lblSettingsDirectory.Location = new System.Drawing.Point(17, 70);
            this.lblSettingsDirectory.Name = "lblSettingsDirectory";
            this.lblSettingsDirectory.Size = new System.Drawing.Size(65, 17);
            this.lblSettingsDirectory.TabIndex = 2;
            this.lblSettingsDirectory.Text = "Directory";
            // 
            // tbSettingsDirectory
            // 
            this.tbSettingsDirectory.Location = new System.Drawing.Point(180, 65);
            this.tbSettingsDirectory.Name = "tbSettingsDirectory";
            this.tbSettingsDirectory.Size = new System.Drawing.Size(491, 22);
            this.tbSettingsDirectory.TabIndex = 1;
            // 
            // btnSettingsSave
            // 
            this.btnSettingsSave.Location = new System.Drawing.Point(603, 463);
            this.btnSettingsSave.Name = "btnSettingsSave";
            this.btnSettingsSave.Size = new System.Drawing.Size(176, 51);
            this.btnSettingsSave.TabIndex = 0;
            this.btnSettingsSave.Text = "Save";
            this.btnSettingsSave.UseVisualStyleBackColor = true;
            this.btnSettingsSave.Click += new System.EventHandler(this.btnSettingsSave_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(552, 441);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(227, 73);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbDirectory
            // 
            this.tbDirectory.Location = new System.Drawing.Point(130, 21);
            this.tbDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.tbDirectory.Name = "tbDirectory";
            this.tbDirectory.Size = new System.Drawing.Size(541, 22);
            this.tbDirectory.TabIndex = 1;
            // 
            // btnDirectory
            // 
            this.btnDirectory.Location = new System.Drawing.Point(679, 19);
            this.btnDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(100, 27);
            this.btnDirectory.TabIndex = 2;
            this.btnDirectory.Text = "Browse";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // tbLogDirectory
            // 
            this.tbLogDirectory.Location = new System.Drawing.Point(130, 62);
            this.tbLogDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.tbLogDirectory.Name = "tbLogDirectory";
            this.tbLogDirectory.Size = new System.Drawing.Size(541, 22);
            this.tbLogDirectory.TabIndex = 3;
            // 
            // btnLogDirectory
            // 
            this.btnLogDirectory.Location = new System.Drawing.Point(679, 60);
            this.btnLogDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogDirectory.Name = "btnLogDirectory";
            this.btnLogDirectory.Size = new System.Drawing.Size(100, 27);
            this.btnLogDirectory.TabIndex = 4;
            this.btnLogDirectory.Text = "Browse";
            this.btnLogDirectory.UseVisualStyleBackColor = true;
            this.btnLogDirectory.Click += new System.EventHandler(this.btnLogDirectory_Click);
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(17, 24);
            this.lblDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(65, 17);
            this.lblDirectory.TabIndex = 5;
            this.lblDirectory.Text = "Directory";
            // 
            // lblLogLocation
            // 
            this.lblLogLocation.AutoSize = true;
            this.lblLogLocation.Location = new System.Drawing.Point(17, 65);
            this.lblLogLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogLocation.Name = "lblLogLocation";
            this.lblLogLocation.Size = new System.Drawing.Size(90, 17);
            this.lblLogLocation.TabIndex = 6;
            this.lblLogLocation.Text = "Log Location";
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(20, 111);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(759, 311);
            this.tbLog.TabIndex = 7;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.cbUseLastRun);
            this.pnlMain.Controls.Add(this.lblCMS);
            this.pnlMain.Controls.Add(this.datepicker);
            this.pnlMain.Controls.Add(this.tbLog);
            this.pnlMain.Controls.Add(this.lblLogLocation);
            this.pnlMain.Controls.Add(this.lblDirectory);
            this.pnlMain.Controls.Add(this.btnLogDirectory);
            this.pnlMain.Controls.Add(this.tbLogDirectory);
            this.pnlMain.Controls.Add(this.btnDirectory);
            this.pnlMain.Controls.Add(this.tbDirectory);
            this.pnlMain.Controls.Add(this.btnStart);
            this.pnlMain.Location = new System.Drawing.Point(277, 52);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(792, 528);
            this.pnlMain.TabIndex = 8;
            // 
            // cbUseLastRun
            // 
            this.cbUseLastRun.AutoSize = true;
            this.cbUseLastRun.Checked = true;
            this.cbUseLastRun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseLastRun.Location = new System.Drawing.Point(20, 441);
            this.cbUseLastRun.Name = "cbUseLastRun";
            this.cbUseLastRun.Size = new System.Drawing.Size(136, 21);
            this.cbUseLastRun.TabIndex = 10;
            this.cbUseLastRun.Text = "Use last run time";
            this.cbUseLastRun.UseVisualStyleBackColor = true;
            this.cbUseLastRun.CheckedChanged += new System.EventHandler(this.cbUseLastRun_CheckedChanged);
            // 
            // lblCMS
            // 
            this.lblCMS.AutoSize = true;
            this.lblCMS.Location = new System.Drawing.Point(20, 474);
            this.lblCMS.Name = "lblCMS";
            this.lblCMS.Size = new System.Drawing.Size(145, 17);
            this.lblCMS.TabIndex = 9;
            this.lblCMS.Text = "Check modified since:";
            this.lblCMS.Visible = false;
            // 
            // datepicker
            // 
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepicker.Location = new System.Drawing.Point(180, 474);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(109, 22);
            this.datepicker.TabIndex = 8;
            this.datepicker.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Only Check (Dir)";
            this.label7.Visible = false;
            // 
            // tbOnlyCheckDir
            // 
            this.tbOnlyCheckDir.Location = new System.Drawing.Point(180, 183);
            this.tbOnlyCheckDir.Name = "tbOnlyCheckDir";
            this.tbOnlyCheckDir.Size = new System.Drawing.Size(491, 22);
            this.tbOnlyCheckDir.TabIndex = 21;
            this.tbOnlyCheckDir.Visible = false;
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 579);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlLeftNav);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Scanner";
            this.Text = "Scanner";
            this.pnlLeftNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlLeftNav;
        private System.Windows.Forms.Button btnScanner;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel pnlTop;
        private Panel pnlSettings;
        private Button btnAbout;
        private Button btnStart;
        private TextBox tbDirectory;
        private Button btnDirectory;
        private TextBox tbLogDirectory;
        private Button btnLogDirectory;
        private Label lblDirectory;
        private Label lblLogLocation;
        private TextBox tbLog;
        private Panel pnlMain;
        private Button btnSettingsSave;
        private Button btnSettingsDirectory;
        private Label lblSettingsDirectory;
        private TextBox tbSettingsDirectory;
        private Button btnSettingsLogLocation;
        private Label lblSettingsLogLocation;
        private TextBox tbSettingsLogLocation;
        private Label label5;
        private TextBox tbSettingsMSPassword;
        private Label label3;
        private TextBox tbSettingsMSUsername;
        private Label label4;
        private TextBox tbSettingsMSHost;
        private Label label1;
        private TextBox tbSettingsEmailFrom;
        private Label label2;
        private TextBox tbSettingsEmailTo;
        private Label lblSettingsTitle;
        private Label label6;
        private TextBox tbOnlyCheck;
        private Label lblCMS;
        private DateTimePicker datepicker;
        private CheckBox cbUseLastRun;
        private Label label7;
        private TextBox tbOnlyCheckDir;
    }
}