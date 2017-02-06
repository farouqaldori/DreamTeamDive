using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diver_Contest
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

            main_auth_form MainForm = new main_auth_form();
            CompetitionRegister Register = new CompetitionRegister();
            PresenterForMain Present = new PresenterForMain(MainForm, Register);

            Application.Run(MainForm); 
            
        }
    }
}
