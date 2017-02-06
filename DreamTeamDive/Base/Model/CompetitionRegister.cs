using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Diver_Contest
{
    public class CompetitionRegister : ICompetition
    {
        main_auth_form MainAuth = new main_auth_form();
        diver_form login = new diver_form();
        void ICompetition.Continute()
        {
            if (MainAuth.LoginButton.Enabled)
            {
                auth_form auth = new auth_form();
                auth.Show();
                MainAuth.Hide();
            }
        }

        void ICompetition.Exit()
        {
            if (MainAuth.ExitButn.Enabled)
            {
                Application.Exit();
            }
        }

        void ICompetition.Jump()
        {
            if(login.JumpButton.Enabled)
            {
                Diver Diver = new Diver();
                Diver.jump();
            }
        }
    }
}
