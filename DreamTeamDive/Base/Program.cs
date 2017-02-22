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
            // Used for Admin presenter
            Admin admin = new Admin();
            AdminRegister adminRegister = new AdminRegister();
            // Used for Diver/Judge Presenter
            main_auth_form MainForm = new main_auth_form();
            CompetitionRegister Register = new CompetitionRegister();
            diver_form DiverForm = new diver_form();
            judge_form JudgeForm = new judge_form();

            PresenterForAdmin AdminPresenter = new PresenterForAdmin(admin, adminRegister);
            PresenterForMain Present = new PresenterForMain(JudgeForm, DiverForm, MainForm, Register);

            Application.Run(admin); 
            
        }
    }
}
