using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_base
{
    public partial class main_mdi : Form
    {
        public main_mdi()
        {
            InitializeComponent();

            // Load home_form window
            home_form home_form = new home_form();
            home_form.MdiParent = this;
            home_form.Show();
        }


        private void nyttFönsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
