using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base
{
    public partial class main_auth_form : Form
    {
        public main_auth_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show authentication form
            if (true)
            {
                // Authentication successful
                judge_form judge_form = new Base.judge_form();
                this.Hide();
                judge_form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Show authentication form
            if (true)
            {
                // Authentication successful
                diver_form diver_form = new Base.diver_form();
                this.Hide();
                diver_form.Show();
            }
        }
    }
}
