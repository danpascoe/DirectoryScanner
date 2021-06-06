using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net.Mail;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Collections.Specialized;
using System.Security.Cryptography.X509Certificates;

namespace DirectoryScanner
{
    public partial class Scanner : Form
    {       
        private RUN_MODE runMode;
        public RUN_MODE RunMode { get { return runMode; } }

        private bool allowEmail;

        public Scanner()
        {
            this.runMode = RUN_MODE.NORMAL;
            InitializeComponent();
            populateFields();
            SetActivePage("main");
        }

        public Scanner(string runMode)
        {
            this.runMode = RUN_MODE.SCHEDULED;
            InitializeComponent();
            populateFields();
            SetActivePage("main");            

            Main.runProgramme("","", tbLog, allowEmail);
            
            Properties.Settings.Default.LastRun = DateTime.Now;
            Properties.Settings.Default.Save();
        }

        private void populateFields()
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.DefaultDirectory)) { tbDirectory.Text = Properties.Settings.Default.DefaultDirectory; }
            if (!String.IsNullOrEmpty(Properties.Settings.Default.DefaultLogLocation)) { tbLogDirectory.Text = Properties.Settings.Default.DefaultLogLocation; }

            tbSettingsDirectory.Text = Properties.Settings.Default.DefaultDirectory;
            tbSettingsLogLocation.Text = Properties.Settings.Default.DefaultLogLocation;
            tbSettingsEmailTo.Text = Properties.Settings.Default.EmailTo;
            tbSettingsEmailFrom.Text = Properties.Settings.Default.EmailFrom;
            tbSettingsMSHost.Text = Properties.Settings.Default.MailServer_Host;
            tbSettingsMSUsername.Text = Properties.Settings.Default.MailServer_userName;
            tbSettingsMSPassword.Text = Properties.Settings.Default.MailServer_password;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbDirectory.Text)) { 
                MessageBox.Show("Please select the directory you wish to scan", "Missing Scan Directory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
                return; 
            }

            if (String.IsNullOrEmpty(tbLogDirectory.Text))
            {                
                MessageBox.Show("Please select the directory you wish to save the log files to", "Missing Log Save Directory", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(
                String.IsNullOrEmpty(Properties.Settings.Default.MailServer_Host) ||
                String.IsNullOrEmpty(Properties.Settings.Default.MailServer_userName) ||
                String.IsNullOrEmpty(Properties.Settings.Default.MailServer_password) ||
                String.IsNullOrEmpty(Properties.Settings.Default.EmailTo) ||
                String.IsNullOrEmpty(Properties.Settings.Default.EmailFrom) &&
                RunMode == RUN_MODE.NORMAL
                )
            {
                DialogResult result = MessageBox.Show("You have not configured a mail server. No email will be sent. Continue?", "No Mail Server Configured", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.No)
                {
                    SetActivePage("settings");
                    return;
                }
                allowEmail = false;
            }
            else { allowEmail = true; }

            if (String.IsNullOrEmpty(Properties.Settings.Default.DefaultDirectory)) {
                DialogResult result = MessageBox.Show("You have not set a default directory. Would you like to set \"" + tbDirectory.Text + "\" as the default?", "Would you like to set defauly directory?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Properties.Settings.Default.DefaultDirectory = tbDirectory.Text;
                    Properties.Settings.Default.Save();
                }
            }

            if (String.IsNullOrEmpty(Properties.Settings.Default.DefaultLogLocation))
            {
                DialogResult result = MessageBox.Show("You have not set a default log save location. Would you like to set \"" + tbLogDirectory.Text + "\" as the default?", "Would you like to set log save location?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Properties.Settings.Default.DefaultLogLocation = tbLogDirectory.Text;
                    Properties.Settings.Default.Save();
                }
            }

            Main.runProgramme(tbDirectory.Text, tbLogDirectory.Text, tbLog, allowEmail);

            Properties.Settings.Default.LastRun = DateTime.Now;
            Properties.Settings.Default.Save();
        }

        private void btnScanner_Click(object sender, EventArgs e)
        {
            SetActivePage("main");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SetActivePage("settings");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            SetActivePage("about");
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select Directory to Scan";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string sSelectedPath = fbd.SelectedPath;
                tbDirectory.Text = sSelectedPath;
            }
        }

        private void btnLogDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select Log Location";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string sSelectedPath = fbd.SelectedPath;
                tbLogDirectory.Text = sSelectedPath;
            }
        }

        private void SetActivePage(string page)
        {
            Color nonActiveColour = Color.FromArgb(53, 65, 79);
            Color activeColour = Color.FromArgb(98, 114, 133);

            switch (page)
            {
                case "main":

                    if(pnlSettings.Visible)
                    {
                        if(
                            Properties.Settings.Default.DefaultDirectory != tbSettingsDirectory.Text || 
                            Properties.Settings.Default.DefaultLogLocation != tbSettingsLogLocation.Text || 
                            Properties.Settings.Default.EmailTo != tbSettingsEmailTo.Text || 
                            Properties.Settings.Default.EmailFrom != tbSettingsEmailFrom.Text || 
                            Properties.Settings.Default.MailServer_Host != tbSettingsMSHost.Text || 
                            Properties.Settings.Default.MailServer_userName != tbSettingsMSUsername.Text || 
                            Properties.Settings.Default.MailServer_password != tbSettingsMSPassword.Text                                                     
                            )
                        {
                            DialogResult result = MessageBox.Show("You have unsaved changes. Would you like to save?", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                Properties.Settings.Default.DefaultDirectory = tbSettingsDirectory.Text;
                                Properties.Settings.Default.DefaultLogLocation = tbSettingsLogLocation.Text;
                                Properties.Settings.Default.EmailTo = tbSettingsEmailTo.Text;
                                Properties.Settings.Default.EmailFrom = tbSettingsEmailFrom.Text;
                                Properties.Settings.Default.MailServer_Host = tbSettingsMSHost.Text;
                                Properties.Settings.Default.MailServer_userName = tbSettingsMSUsername.Text;
                                Properties.Settings.Default.MailServer_password = tbSettingsMSPassword.Text;

                                Properties.Settings.Default.Save();

                                tbDirectory.Text = Properties.Settings.Default.DefaultDirectory;
                                tbLogDirectory.Text = Properties.Settings.Default.DefaultLogLocation;
                            }   
                        }
                    }

                    pnlMain.Visible = true;
                    pnlSettings.Visible = false;

                    btnAbout.BackColor = nonActiveColour;
                    btnSettings.BackColor = nonActiveColour;
                    btnScanner.BackColor = activeColour;

                    break;

                case "settings":
                    pnlMain.Visible = false;
                    pnlSettings.Visible = true;

                    btnAbout.BackColor = nonActiveColour;
                    btnSettings.BackColor = activeColour;
                    btnScanner.BackColor = nonActiveColour;

                    break;

                case "about":
                    break;

                default:
                    break;
            }
        }
        
        private void btnSettingsSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DefaultDirectory = tbSettingsDirectory.Text;
            Properties.Settings.Default.DefaultLogLocation = tbSettingsLogLocation.Text;
            Properties.Settings.Default.EmailTo = tbSettingsEmailTo.Text;
            Properties.Settings.Default.EmailFrom = tbSettingsEmailFrom.Text;
            Properties.Settings.Default.MailServer_Host = tbSettingsMSHost.Text;
            Properties.Settings.Default.MailServer_userName = tbSettingsMSUsername.Text;
            Properties.Settings.Default.MailServer_password = tbSettingsMSPassword.Text;

            Properties.Settings.Default.Save();
        }

        private void btnSettingsLogLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select Directory to Scan";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string sSelectedPath = fbd.SelectedPath;
                tbSettingsLogLocation.Text = sSelectedPath;
            }
        }

        private void btnSettingsDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select Directory to Scan";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string sSelectedPath = fbd.SelectedPath;
                tbSettingsDirectory.Text = sSelectedPath;
            } 
        }
    }
}