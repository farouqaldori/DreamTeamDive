using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diver_Contest
{
    public partial class judge_form : MetroFramework.Forms.MetroForm, IFormMain
    {
        public event DelegateLogin EventLogin = null;
        public event DelegateExit EventExit = null;
        public event DelegateJump EventJump = null;
        public event DelegateUpdateJumps EventUpdateJumps = null;
        public event DelegateSendRating EventSendRating = null;

        public Judge judge;

        public judge_form()
        {
            InitializeComponent();
        }

        private void judge_form_Load(object sender, EventArgs e)
        {

        }

        private void SendRatingButton_Click(object sender, EventArgs e)
        {
          if (this.EventSendRating != null)
          {
                EventSendRating();
          }
        }
    }
}
