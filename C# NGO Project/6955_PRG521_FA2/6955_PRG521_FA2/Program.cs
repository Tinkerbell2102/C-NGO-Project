using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6955_PRG521_FA2
{
    static class Program
    {
        public static String UsrProfileApp = "";
        public static String UsrNameApp = "";
        public static String UsrLastNameApp = "";
        public static String UsrOrgNameApp = "";
        public static String UsrContactNoApp = "";
        public static String UsrContactMailApp = "";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

       
    }
}
