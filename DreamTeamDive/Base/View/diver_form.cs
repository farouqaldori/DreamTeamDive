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
    public partial class diver_form : MetroFramework.Forms.MetroForm, IFormMain
    {
        public diver_form()
        {
            InitializeComponent();
        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void metroProgressSpinner1_Click(object sender, EventArgs e)
        {

        }

        private void diver_form_Load(object sender, EventArgs e)
        {

        }

        private void metroProgressSpinner4_Click(object sender, EventArgs e)
        {

        }

        private void Jump_Click(object sender, EventArgs e)
        {
            diver_form form = new diver_form();
            Diver div = new Diver();
            if (this.EventJump != null)
                EventJump(div, form);
        }

        public event DelegateLogin EventLogin = null;
        public event DelegateExit EventExit = null;
        public event DelegateJump EventJump = null;

    }
}
