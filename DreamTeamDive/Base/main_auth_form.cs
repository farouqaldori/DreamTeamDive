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
            // Authentication successful for Judge
            auth_form authform = new Base.auth_form('J');
                
            authform.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          // Authentication successful for Diver
            auth_form authform = new Base.auth_form('D');

            authform.Show();
        }
    }
}
