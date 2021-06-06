using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryScanner
{
    static class Main
    {

        static TextBox tbLog;
        static List<String> outputFiles = new List<String>();

        private static bool allowSendEmail = true;

        public static void runProgramme(string dir, string logDir, TextBox tb, bool allowEmail)
        {
            tbLog = tb;

            allowSendEmail = allowEmail;

            string startTime = DateTime.Now.ToString("t");

            string date = DateTime.Now.ToString("ddMMMyyyy", CultureInfo.InvariantCulture) + "_" + startTime.Replace(":", "");
            string fileName = "log_" + date + ".txt";

            outputFiles.Clear();

            printToLog("---------------------------------------------------------");
            printToLog("---------------------------------------------------------");
            printToLog("Getting Files...");
            printToLog("---------------------------------------------------------");
            printToLog("---------------------------------------------------------");

            FindAllFiles(dir);
            outputFiles = outputFiles.Distinct().ToList();
           
            if (outputFiles.Count > 0)
            {

                printToLog("---------------------------------------------------------");
                printToLog("---------------------------------------------------------");
                printToLog("Creating Log for (" + outputFiles.Count + ") Records");
                printToLog("---------------------------------------------------------");
                printToLog("---------------------------------------------------------");

                TextWriter txt = new StreamWriter(logDir + "/" + fileName);

                foreach (string file in outputFiles)
                {
                    txt.WriteLine(file);
                }

                txt.Close();
                printToLog("Complete");
                SendEmail(outputFiles.Count, startTime, logDir, fileName);
            }
            else
            {
                printToLog("---------------------------------------------------------");
                printToLog("---------------------------------------------------------");
                printToLog("No Changes Made");
                printToLog("---------------------------------------------------------");
                printToLog("---------------------------------------------------------");
            }
        }

        public static void FindAllFiles(string folder)
        {
            string[] files = Directory.GetFiles(folder);
            foreach (string sFile in files)
            {
                try
                {
                    if (isFileAllowed(sFile))
                    {
                        DateTime lastModified = System.IO.File.GetLastWriteTime(sFile);
                        printToLog("Checking: " + sFile + " - Last Mod: " + lastModified);

                        if (lastModified > Properties.Settings.Default.LastRun)
                        {
                            outputFiles.Add(lastModified + " - " + sFile);
                        }
                    }
                }
                catch { }
            }            

            foreach (string subDir in Directory.GetDirectories(folder))
            {
                if (isFileAllowed(subDir))
                {
                    try { FindAllFiles(subDir); }
                    catch { }
                }
            }
        }

        public static bool isFileAllowed(string sFile)
        {
            if (File.GetAttributes(sFile).HasFlag(FileAttributes.Hidden)) { return false; }
            else if (File.GetAttributes(sFile).HasFlag(FileAttributes.System)) { return false; }
            else { return true; }
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

        private static void printToLog(string log)
        {
            tbLog.AppendText(log + "\r\n");
        }
    }
}
