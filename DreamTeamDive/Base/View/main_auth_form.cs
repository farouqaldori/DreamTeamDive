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
        public main_auth_form()
        {
            InitializeComponent();
        }

        private void main_auth_form_Load(object sender, EventArgs e)
        {

        }

        public void Login_Click(object sender, EventArgs e)
        {
            if(this.EventLogin != null)
                this.EventLogin();
        }

        public void ExitButn_Click(object sender, EventArgs e)
        {
            if(this.EventExit != null)
             this.EventExit();
        }

        public event DelegateLogin EventLogin = null;
        public event DelegateExit EventExit = null;
        public event DelegateJump EventJump = null;

        private void main_auth_form_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void TextBox_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
