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
        public event DelegateGetJump EventGetJump = null;

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

        private void jump_rater_backgroundworker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (this.EventGetJump != null)
                {
                    EventGetJump();
                    // Update every 5 seconds
                    System.Threading.Thread.Sleep(5000);
                }
            }
        }

        string ToGender(string gender)
        {
            if (gender == "0")
            {
                return "Male";
            } else
            {
                return "Female";
            }

        }

        // The mode variable is to make the backgroundworker update or display "Awaiting". This is updated from the presenter.
        public int mode;
        public int currentJumpId = 0;
        private void jump_rater_backgroundworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState != null)
            {
                // If none found
                if (mode == 0)
                {
                    currentJumpId = 0;

                    // Update diver information
                    CurrentDiverNameLabel.Text = "Awaiting";
                    CurrentDiverGenderLabel.Text = "Awaiting";

                    // Updte jump information
                    StyleLabel.Text = "Awaiting";
                    DifficultyLabel.Text = "Awaiting";
                    FormLabel.Text = "Awaiting";
                    startingLabel.Text = "Awaiting";
                    approachLabel.Text = "Awaiting";
                    takeoffLabel.Text = "Awaiting";
                    flightLabel.Text = "Awaiting";
                    entryLabel.Text = "Awaiting";

                    // Lock input
                    SendRatingButton.Enabled = false;
                    RatingBox.Enabled = false;
                } else
                // If found
                {
                    // Cast conversion
                    Tuple<Jump, Diver> newJumpDiver = (Tuple<Jump, Diver>)e.UserState;

                    currentJumpId = newJumpDiver.Item1.id;

                    // Update diver information
                    CurrentDiverNameLabel.Text = newJumpDiver.Item2.name;
                    CurrentDiverGenderLabel.Text = ToGender(newJumpDiver.Item2.gender);

                    // Updte jump information
                    StyleLabel.Text = newJumpDiver.Item1.style.ToString();
                    DifficultyLabel.Text = newJumpDiver.Item1.difficulty.ToString();
                    FormLabel.Text = newJumpDiver.Item1.form.ToString();
                    startingLabel.Text = newJumpDiver.Item1.starting.ToString();
                    approachLabel.Text = newJumpDiver.Item1.approach.ToString();
                    takeoffLabel.Text = newJumpDiver.Item1.takeOff.ToString();
                    flightLabel.Text = newJumpDiver.Item1.flight.ToString();
                    entryLabel.Text = newJumpDiver.Item1.entry.ToString();

                    // Unlock input
                    SendRatingButton.Enabled = true;
                    RatingBox.Enabled = true;
                }

            }
        }
    }
}
