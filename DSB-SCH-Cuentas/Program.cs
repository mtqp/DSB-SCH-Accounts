using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Accounts
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
            Application.ThreadException += Application_ThreadException;
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new frmAccounts());
            }
            catch (Exception e)
            {
                Log(e);
                new ErrorMessage(e).ShowDialog();
            }
        }

        private static void Log(Exception e)
        {
            //throw new NotImplementedException();
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Log(e.Exception);
            new ErrorMessage(e.Exception).Show();
        }
    }
}
