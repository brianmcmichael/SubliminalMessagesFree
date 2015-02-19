using System;
using System.Collections;
using System.Windows.Forms;

namespace Subliminal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] strarrParms)
        {
            // Initializing settings
            Settings.GetSettings().CommandParms = new ArrayList();

            // Checking if any command line parameter was given
            foreach (string strParm in strarrParms)
            {
                Settings.GetSettings().CommandParms.Add(strParm);
            }

            // Running the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
