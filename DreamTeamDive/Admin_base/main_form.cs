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
        // Count how many windows are open.
        public int windowCounter = 0;

        public main_mdi()
        {
            InitializeComponent();            
        }


        private void nyttFönsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            participents_form participents = new participents_form(this);

            participents.MdiParent = this;
            participents.Text = windowCounter.ToString();
            participents.Show();

            windowCounter++;
        }
    }
}
