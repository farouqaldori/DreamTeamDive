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

        public void metroButton1_Click(object sender, EventArgs e)
        {
            if(this.EventContinue != null)
                this.EventContinue();
        }

        public void ExitButn_Click(object sender, EventArgs e)
        {
            if (this.EventExit != null)
                 this.EventExit();
        }

        public event DelegateConinute EventContinue = null;
        public event DelegateExit EventExit = null;
        

    }
}
