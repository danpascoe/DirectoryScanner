using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DirectoryScanner
{
    static class Main
    {
        static TextBox tbLog;
        static List<String> outputFiles = new List<String>();
        static string[] OnlyCheck;
        private static bool allowSendEmail = true;

        public static void runProgramme(string dir, string logDir, TextBox tb, bool allowEmail, DateTime checkFrom, RUN_MODE runMode = RUN_MODE.NORMAL)
        {
            // Sets the global variables
            tbLog = tb;
            allowSendEmail = allowEmail;

            // Log Filename
            string startTime = DateTime.Now.ToString("t");          
            string date = DateTime.Now.ToString("ddMMMyyyy", CultureInfo.InvariantCulture) + "_" + startTime.Replace(":", "");
            string fileName = "log_" + date + ".txt";

            // If the user has set up a only check rule in the Settings tab, will add each string to an array (split on semi-colon)
            if(!String.IsNullOrEmpty(Properties.Settings.Default.OnlyCheck))
            {
                OnlyCheck = new string[] { };
                OnlyCheck = Properties.Settings.Default.OnlyCheck.Split(';');                               
            }
            
            outputFiles.Clear();

            printToLog("-------------------------------------------------------------------------------------------------------------------");
            printToLog("-------------------------------------------------------------------------------------------------------------------");
            printToLog("Getting Files...");
            printToLog("Checking for files modified after " + checkFrom + "...");
            printToLog("-------------------------------------------------------------------------------------------------------------------");
            printToLog("-------------------------------------------------------------------------------------------------------------------");

            // This function is the main function that gets all the files and checks for changes
            FindAllFiles(dir, checkFrom);
            
            // Removes any duplicates from the list
            outputFiles = outputFiles.Distinct().ToList();
           
            // Completes different actions depending on if there have been any changes
            if (outputFiles.Count > 0)
            {                
                printToLog("-------------------------------------------------------------------------------------------------------------------"); 
                printToLog("-------------------------------------------------------------------------------------------------------------------");
                printToLog("Creating Log for (" + outputFiles.Count + ") Records");
                printToLog("-------------------------------------------------------------------------------------------------------------------");
                printToLog("-------------------------------------------------------------------------------------------------------------------");

                // Creates new text file and saves it to the relevent directory
                // Prints each file and last modified date to text file
                TextWriter txt = new StreamWriter(logDir + "/" + fileName);

                foreach (string file in outputFiles)
                {
                    txt.WriteLine(file);
                }

                txt.Close();
                printToLog("Complete");

                
                if (allowEmail) { SendEmail(outputFiles.Count, startTime, logDir, fileName); }
            }
            else
            {
                printToLog("-------------------------------------------------------------------------------------------------------------------");
                printToLog("-------------------------------------------------------------------------------------------------------------------");                
                printToLog("No Changes Made");
                printToLog("-------------------------------------------------------------------------------------------------------------------");
                printToLog("-------------------------------------------------------------------------------------------------------------------");

                if (runMode == RUN_MODE.SCHEDULED && allowEmail)
                {
                    SendNoChangeEmail(startTime, dir);
                }
            }
        }

        // Looks in directory and checks to see if the last modified date is after the checkFrom Date
        // Adds file into outputFiles List if been modified
        // Function is recursive and calls itself for each directory
        public static void FindAllFiles(string folder, DateTime checkFrom)
        {
            // Gets all files in directory
            string[] files = Directory.GetFiles(folder);
            foreach (string sFile in files)
            {
                try
                {
                    // Checks if the file is allowed (based on the OnlyCheck array)
                    if (isFileAllowed(sFile))
                    {
                        // Gets last modified date, checks to see if it has been modified more recently than the passed in date
                        // Adds to OutputFiles List
                        DateTime lastModified = System.IO.File.GetLastWriteTime(sFile);
                        printToLog("Checking: " + sFile + " - Last Mod: " + lastModified);

                        if (lastModified > checkFrom)
                        {
                            outputFiles.Add(lastModified + " - " + sFile);
                        }
                    }
                }
                catch { }
            }

            // Foreach Sub Directory, calls the FindAllFiles function recursively 
            foreach (string subDir in Directory.GetDirectories(folder))
            {
                // Checks if folder is allowed 
                // I would like to add a field in settings to check folder name. For now, this checks if the folder is hidden
                // Marked as Directory with the second param
                if (isFileAllowed(subDir, true))
                {
                    try { FindAllFiles(subDir, checkFrom); }
                    catch { }
                }
            }
        }

        public static bool isFileAllowed(string sFile, bool checkDir = false)
        {
            // Gets File Attributes and checks if the file is a system file or if the file is hidden
            FileAttributes fa = File.GetAttributes(sFile);
            if (fa.HasFlag(FileAttributes.Hidden) || fa.HasFlag(FileAttributes.System)) { return false; }            
            else {
                // Skips this if a directory is being checked
                if (!checkDir)
                {
                    // If there is any strings in the OnlyCheck Array, it loops through to see if there is a match and returns result
                    if (OnlyCheck != null && OnlyCheck.Length > 0)
                    {
                        bool hasMatch = false;
                        foreach (string str in OnlyCheck)
                        {
                            if (sFile.IndexOf(str) > 0) { hasMatch = true; }                         
                        }
                        return hasMatch;                        
                    }
                    else { return true; }
                }
                else { return true; }
            }
        }
  
        public static void SendEmail(int count, string startTime, string filepath, string fileName)
        {
            SmtpClient client = new SmtpClient();
            client.Host = Properties.Settings.Default.MailServer_Host;
            client.Credentials = new System.Net.NetworkCredential(Properties.Settings.Default.MailServer_userName, Properties.Settings.Default.MailServer_password);

            MailAddress mailTFrom = new MailAddress(Properties.Settings.Default.EmailFrom, "Directory Scanner");
            MailAddress mailTo = new MailAddress(Properties.Settings.Default.EmailTo);

            MailMessage message = new MailMessage(mailTFrom, mailTo);
            message.Subject = "Directory Scanner Report - " + DateTime.Now.ToString("dd MMM yyyy") + " - " + count + "  Change" + (count == 1 ? "" : "s") + " found";

            string body = "The Directory Scanner ran at " + startTime + " and found " + count + " change" + (count == 1 ? "" : "s") + ".";
            body += "You can see a log of any files that have been changed here:  " + filepath; 

            Attachment attachment = new Attachment(filepath + "/" + fileName);
            message.Attachments.Add(attachment);

            message.Body = body;
            client.Send(message);
        }

        public static void SendNoChangeEmail(string startTime, string filepath)
        {
            SmtpClient client = new SmtpClient();
            client.Host = Properties.Settings.Default.MailServer_Host;
            client.Credentials = new System.Net.NetworkCredential(Properties.Settings.Default.MailServer_userName, Properties.Settings.Default.MailServer_password);

            MailAddress mailTFrom = new MailAddress(Properties.Settings.Default.EmailFrom, "Directory Scanner");
            MailAddress mailTo = new MailAddress(Properties.Settings.Default.EmailTo);

            MailMessage message = new MailMessage(mailTFrom, mailTo);
            message.Subject = "Directory Scanner Report - " + DateTime.Now.ToString("dd MMM yyyy") + " - No Changes found";

            string body = "The Directory Scanner ran at " + startTime + " and found no changes within: \"" + filepath + "\".";

            message.Body = body;
            client.Send(message);
        }

        private static void printToLog(string log)
        {
            tbLog.AppendText(log + "\r\n");
        }
    }
}
