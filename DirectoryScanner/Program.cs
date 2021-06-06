using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryScanner
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // When setting up the scanner as a scheduled task, you must add a argument.
            // Creates a Scanner (Scanner.cs) and passes in Args if exists. This is so the scanner knows if it is a scheduled task or not.

            if (args != null && args.Length > 0) { Application.Run(new Scanner(args[0])); }
            else { Application.Run(new Scanner()); }
        }
    }
}
