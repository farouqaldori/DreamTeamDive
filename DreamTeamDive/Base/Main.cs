using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIGUI
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        public Main()
        {
            InitializeComponent();
            this.StyleManager = msmMain;
        }

        private void Light_Click(object sender, EventArgs e)
        {
            msmMain.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void Dark_Click(object sender, EventArgs e)
        {
            msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            msmMain.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(metroComboBox1.Text);
        }


        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

//participents_form participents;
//private void nyttFönsterToolStripMenuItem_Click(object sender, EventArgs e)
//{
//    if (participents == null)
//    {
//        participents = new participents_form();
//        participents.MdiParent = this;
//        participents.Show();
//    }
//    else
//    {
//        participents.Activate();
//    }

//}


//private void öppnaToolStripMenuItem_Click(object sender, EventArgs e)
//{
//    Stream myStream = null;
//    OpenFileDialog openFileDialog1 = new OpenFileDialog();

//    openFileDialog1.InitialDirectory = "c:\\";
//    openFileDialog1.Filter = "shp files (*.shp)|*.shp|All files (*.*)|*.*";
//    openFileDialog1.FilterIndex = 2;
//    openFileDialog1.RestoreDirectory = true;

//    if (openFileDialog1.ShowDialog() == DialogResult.OK)
//    {
//        try
//        {
//            if ((myStream = openFileDialog1.OpenFile()) != null)
//            {
//                using (myStream)
//                {
//                    // Insert code to read the stream here.
//                }
//            }
//        }
//        catch (Exception ex)
//        {
//            MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
//        }
//    }
//}

