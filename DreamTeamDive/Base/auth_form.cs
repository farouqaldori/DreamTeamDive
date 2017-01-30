using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Member_base
{
    public partial class auth_form : Form
    {

        char AuthWho;
        public auth_form(char who)
        {
            InitializeComponent();
            //Autentication av Dommare/Hoppare, tar en parameter J eller H
            AuthWho = who;
        }

        private void auth_form_Load(object sender, EventArgs e)
        {

        }

        private void auth_button_Click(object sender, EventArgs e)
        {

            //Kollar om det är dommare eller hoppare
            if (AuthWho == 'J')
            {
                judge_form judgeform = new Member_base.judge_form();
                this.Hide();
                judgeform.Show();
            }
            else if(AuthWho == 'D')
            {
                diver_form diverform = new Member_base.diver_form();
                this.Hide();
                diverform.Show();
            }
            else
            {
                MessageBox.Show("Wrong, Try again!");
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
