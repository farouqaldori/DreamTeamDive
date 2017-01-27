using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        }

        participents_form participents;
        private void nyttFönsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (participents==null)
            {
                participents = new participents_form();
                participents.MdiParent = this;
                participents.Show();
            }else
            {
                participents.Activate();  
            }
            
        }

        
        private void öppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Predefined extention to standard "open Window"
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog()==DialogResult.OK)
            {
                StreamReader reader = new StreamReader(File.OpenRead(open.FileName));
                //To do: ways to open a specific file
            }
        }

        private void sparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Predefined extention to standard "open Window"
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog()==DialogResult.OK)
            {
                StreamReader reader = new StreamReader(File.OpenRead(open.FileName));
                //To do: ways to save a specific file
            }
        }
    }
}
