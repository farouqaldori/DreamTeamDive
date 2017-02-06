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
    public class Register : ModelV
    {
        main_auth_form mainf = new main_auth_form();
        void ModelV.Continute()
        {
            if (mainf.LoginButton.Enabled)
            {
                auth_form auth = new auth_form();
                auth.Show();
                mainf.Hide();
            }
        }

        void ModelV.Exit()
        {
            if (mainf.ExitButn.Enabled)
            {
                Application.Exit();
            }
        }
    }
}
