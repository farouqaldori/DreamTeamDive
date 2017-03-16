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
    public partial class spectator_form: MetroFramework.Forms.MetroForm , IFormMain
    {
        public event DelegateLogin EventLogin;
        public event DelegateExit EventExit;
        public event DelegateJump EventJump;
        public event DelegateUpdateJumps EventUpdateJumps;
        public event DelegateSendRating EventSendRating;
        public event DelegateGetJump EventGetJump;
        public event DelegateGetRatingDivers EventGetRatingDivers;

        public Diver diver; 
        public spectator_form()
        {
            InitializeComponent();
        }

        private void spectator_form_Load(object sender, EventArgs e)
        {

        }

        

        private void comp_updater_backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (this.EventGetRatingDivers != null)
                {
                    EventGetRatingDivers();
                    //Update compition when jump occurs
                    System.Threading.Thread.Sleep(5000);
                }
            }
        }

        public int _mode;
        public int _currentRound = 0;
        //funktion to keep updating current compition
        private void comp_updater_backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState != null)
            {
                if (_mode == 0)
                {
                    _currentRound = 0;
                    AwaitingLabelMale.Show();
                    AwaitingLabelMale.Enabled = false;
                }else
                {
                    List<Diver> MaleDivers = (List<Diver>)e.UserState;

                    //_currentRound = MaleDivers.id;
                    m1JumperLabel.Text = MaleDivers.
                }
            }
        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }
    }
}
