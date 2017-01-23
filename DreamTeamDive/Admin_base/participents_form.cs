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
    public partial class participents_form : Form
    {

        // Create a new form to be able to manipulate the parent form.
        private main_mdi _parent;

        public participents_form(main_mdi parent)
        {
            this._parent = parent;
            InitializeComponent();
        }

        private void participents_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Reset parent window counter 
            _parent.windowCounter--;

            // Reset parent window counter

        }
    }
}
