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
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory="c:\\";
            openFileDialog1.Filter="shp files (*.shp)|*.shp|All files (*.*)|*.*";
            openFileDialog1.FilterIndex=2;
            openFileDialog1.RestoreDirectory=true;

            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    if((myStream=openFileDialog1.OpenFile())!=null)
                    {
                        using(myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                } catch(Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: "+ex.Message);
                }
            }
        }

        private void sparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Predefined extention to standard "save Window"
            Stream myStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "shp file (*.shp)|*.shp|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream =saveFileDialog.OpenFile()) != null)
                {
                    // code to write the stream goes here
                    myStream.Close();
                }
            }

        }
    }
}
