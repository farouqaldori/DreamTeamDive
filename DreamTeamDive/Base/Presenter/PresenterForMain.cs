using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Diver_Contest
{
    public class PresenterForMain 
    {
        public main_auth_form _mainform { get; set; }
        public diver_form _diverform { get; set; }
        public judge_form _judgeform { get; set; }
        public ICompetition _Model { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="view"></param>
        public PresenterForMain(judge_form judgeform, diver_form diverform, main_auth_form mainform, CompetitionRegister cr)
        {
            this._Model = cr;
            this._mainform = mainform;
            this._diverform = diverform;
            this._judgeform = judgeform;
            // Start db connection
            this._Model.StartConnection();

            this._mainform.EventLogin += Login;
            this._mainform.EventExit += Exit;

            this._diverform.EventJump += Jump;
            this._diverform.EventUpdateJumps += UpdateJumps;

            this._judgeform.EventSendRating += RateJump;
            this._judgeform.EventGetJump += GetJumps;
        }

        public void UpdateJumps()
        {
            List <Jump> newJumps = this._Model.UpdateJumps(_diverform.diver.id);
            this._diverform.diver.jumps = newJumps;
            this._diverform.jump_updater_backgroundWorker.ReportProgress(1, newJumps);
        }

        public void GetJumps()
        {
            try
            {
                Tuple<Jump, Diver> newJumpDiver = this._Model.GetJumps(_judgeform.judge.competition);
                this._judgeform.mode = 1;
                this._judgeform.jump_rater_backgroundworker.ReportProgress(1, newJumpDiver);
            }
            catch
            {
                // Unable to get any divers to rate.
                this._judgeform.mode = 0;
                this._judgeform.jump_rater_backgroundworker.ReportProgress(1, 0);
            }
        }

        public void Login()
        {
            this._mainform.authBox.Enabled = false;
            this._mainform.LoginButton.Enabled = false;
            
            string authCode = _mainform.authBox.Text;
            if (_mainform.diver_radio_button.Checked)
            {
                // If the user is a diver, check auth input.
                try
                {
                    // Authentication successfull
                    Diver diver = this._Model.DiverLogin(authCode);
                    _mainform.Hide();
                    _diverform.diver = diver;
                    _diverform.Text = "Welcome, " + diver.name;
                    _diverform.jump_updater_backgroundWorker.RunWorkerAsync();
                    _diverform.Show();
                }
                catch
                {
                    // Authentication failed
                    System.Windows.Forms.MessageBox.Show("Please re-enter your authentication or choose the right type.", "Error!");
                    this._mainform.authBox.Enabled = true;
                    this._mainform.LoginButton.Enabled = true;
                }
            }
            else if (_mainform.judge_radio_button.Checked)
            {
                // If the user is a judge, check auth input.
                try
                {
                    // Information is accurate.
                    Judge judge = this._Model.JudgeLogin(authCode);
                    _mainform.Hide();
                    _judgeform.judge = judge;
                    _judgeform.Text = "Welcome, " + judge.name;
                    _judgeform.jump_rater_backgroundworker.RunWorkerAsync();
                    _judgeform.Show();
                }
                catch
                {
                    // Information is false
                    System.Windows.Forms.MessageBox.Show("Please re-enter your authentication or choose the right type.", "Error!");
                    this._mainform.authBox.Enabled = true;
                    this._mainform.LoginButton.Enabled = true;
                }
            }
        }

        public void Jump()
        {
            this._diverform.JumpButton.Enabled = false;
            if (_diverform.diver.jumpIndex != 0)
            {
                // Check if diver used all jumps.
                if (_diverform.diver.jumpIndex == 6)
                {
                    System.Windows.Forms.MessageBox.Show("You have used all your jumps, please wait for the results.", "Info!");
                    this._diverform.JumpButton.Enabled = true;
                    return;
                }
                // Check if previous jump has been graded.
                if (_diverform.diver.jumps[_diverform.diver.jumpIndex-1].status != 2)
                {
                    System.Windows.Forms.MessageBox.Show("Please wait until your previous jump has been graded.", "Info!");
                    this._diverform.JumpButton.Enabled = true;
                    return;
                }
            }
            this._Model.Jump(_diverform.diver);
            this._diverform.JumpButton.Enabled = true;
        }

        public void RateJump()
        {
            this._judgeform.SendRatingButton.Enabled = false;
            this._Model.SendRating(_judgeform.judge, _judgeform.currentJumpId, _judgeform.RatingBox.Text);
        }
        
        public void Exit()
        {
            this._Model.Exit();
        }

    }
}
