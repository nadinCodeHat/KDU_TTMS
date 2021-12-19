using System;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forgot_Password());
        }
    }
}
