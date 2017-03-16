using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diver_Contest
{
    public partial class main_auth_form : MetroFramework.Forms.MetroForm, IFormMain
    {
        public event DelegateLogin EventLogin = null;
        public event DelegateExit EventExit = null;
        public event DelegateJump EventJump = null;
        public event DelegateUpdateJumps EventUpdateJumps = null;
        public event DelegateSendRating EventSendRating = null;
        public event DelegateGetJump EventGetJump = null;
        public event DelegateGetRatingDivers EventGetRatingDivers = null;
        public event DelegateGetEndResultDivers EventGetEndResultDivers = null;

        public main_auth_form()
        {
            InitializeComponent();
        }


        public void Login_Click(object sender, EventArgs e)
        {
            if (this.EventLogin != null)
            {
                this.EventLogin();
            }
        }

        public void ExitButn_Click(object sender, EventArgs e)
        {
            if (this.EventExit != null)
            {
                this.EventExit();
            }
        }

        private void main_auth_form_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void TextBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void authBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiverButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void show_pass_button_Click(object sender, EventArgs e)
        {
            if (authBox.UseSystemPasswordChar)
            {
                authBox.UseSystemPasswordChar = false;
            } else
            {
                authBox.UseSystemPasswordChar = true;
            }
        }
    }
}
