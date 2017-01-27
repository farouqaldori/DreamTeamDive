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
    public partial class diver_form : Form
    {
        public diver_form()
        {
            InitializeComponent();
        }

        private void jumpstyle_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void diver_form_Load(object sender, EventArgs e)
        {
            // Disable manual input of values to the combo box.
            jumpstyle_combobox.SelectedIndex = 0;
            jumpstyle_combobox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("101A – forward Dive Straight\n203C – back one-and-a-half somersaults, tuck\n305C - reverse two-and-a-half somersaults,tuck\n113B – flying forward one-and-a-half somersaults, pike\n" +
                "5211A – back dive, half twist, straight position\n5337D – reverse one and a half somersaults with three and a half twists, in the Free position\n"+
                "600A – armstand dive straight\n612B – armstand forward somersault pike\n624C – armstand back double somersault tuck", "Information");
        }
    }
}
