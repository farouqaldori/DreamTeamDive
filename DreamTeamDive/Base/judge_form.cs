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
    public partial class judge_form : Form
    {
        public judge_form()
        {
            InitializeComponent();
        }

        private void judge_form_Load(object sender, EventArgs e)
        {
            // Disable manual input of values to the combo box.
            rating_combobox.SelectedIndex = 0;
            rating_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check Input
            if (rating_combobox.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a grade.", "Error!", MessageBoxButtons.OK);
            }
        }
    }
}
