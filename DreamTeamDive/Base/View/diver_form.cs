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
    public partial class diver_form : MetroFramework.Forms.MetroForm, IFormMain
    {
        public event DelegateLogin EventLogin = null;
        public event DelegateExit EventExit = null;
        public event DelegateJump EventJump = null;
        public event DelegateUpdateJumps EventUpdateJumps = null;

        public Diver diver;

        public diver_form()
        {
            InitializeComponent();
        }
        
        private void Jump_Click(object sender, EventArgs e)
        {
            if (this.EventJump != null)
                EventJump();
        }

        private void jump_updater_backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (this.EventUpdateJumps != null)
                {
                    EventUpdateJumps();
                    // Update every 5 seconds
                    System.Threading.Thread.Sleep(5000);
                }
            }
        }

        /// <summary>
        /// Return text values depending on status.
        /// </summary>
        /// <param name="status">The status to change.</param>
        /// <returns></returns>
        private string statusToString(int status)
        {
            if (status == 0)
            {
                return "Idle";
            } else if (status == 1)
            {
                return "Awaiting";
            } else
            {
                return "Graded";
            }
        }

        /// <summary>
        /// Return color depending on status.
        /// </summary>
        /// <param name="status">The status to change.</param>
        /// <returns></returns>
        private Color statusToColor(int status)
        {
            if (status == 0)
            {
                return Color.Gray;
            }
            else if (status == 1)
            {
                return Color.Orange;
            }
            else
            {
                return Color.Green;
            }
        }

        private void jump_updater_backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState != null)
            {
                List<Jump> newJumps = (List<Jump>)e.UserState;

                Jump1Label.Text = statusToString(newJumps[0].status);
                Jump1Label.ForeColor = statusToColor(newJumps[0].status);

                Jump2Label.Text = statusToString(newJumps[1].status);
                Jump2Label.ForeColor = statusToColor(newJumps[1].status);

                Jump3Label.Text = statusToString(newJumps[2].status);
                Jump3Label.ForeColor = statusToColor(newJumps[2].status);

                Jump4Label.Text = statusToString(newJumps[3].status);
                Jump4Label.ForeColor = statusToColor(newJumps[3].status);

                Jump5Label.Text = statusToString(newJumps[4].status);
                Jump5Label.ForeColor = statusToColor(newJumps[4].status);

                Jump6Label.Text = statusToString(newJumps[5].status);
                Jump6Label.ForeColor = statusToColor(newJumps[5].status);
            }
        }
    }
}
