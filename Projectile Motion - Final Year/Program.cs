using System;
using System.Windows.Forms;

namespace Projectile_Motion___Final_Year
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fm_MainForm());
        }
    }
}
