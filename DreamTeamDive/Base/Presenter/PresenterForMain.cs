using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Base.View;
using MySql.Data.MySqlClient;

namespace Diver_Contest
{
    public class PresenterForMain 
    {
        public main_auth_form _mainform { get; set; }
        public diver_form _diverform { get; set; }
        public judge_form _judgeform { get; set; }
        public spectator_form _Spectatorform { get; set; }
        public ICompetition _Model { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="view"></param>
        public PresenterForMain(judge_form judgeform, diver_form diverform, 
            main_auth_form mainform, CompetitionRegister cr, spectator_form spectatorform )
        {
            this._Model = cr;
            this._mainform = mainform;
            this._diverform = diverform;
            this._judgeform = judgeform;
            this._Spectatorform = spectatorform;

            // Start db connection
            this._Model.StartConnection();

            this._mainform.EventLogin += Login;
            this._mainform.EventExit += Exit;

            this._diverform.EventJump += Jump;
            this._diverform.EventUpdateJumps += UpdateJumps;
            this._diverform.EventCompDone += CompDone;

            this._judgeform.EventSendRating += RateJump;
            this._judgeform.EventGetJump += GetJumps;

            this._Spectatorform.EventGetRatingDivers += GetRatingDivers;
            this._Spectatorform.EventGetRatingDivers += GetEndResultDivers;
        }

        public void GetRatingDivers()
        {
            List<Diver> diverStandings = this._Model.GetRatingDivers();
            this._Spectatorform.diver = diverStandings;

        }
        public void GetEndResultDivers()
        {
            List<Diver> endResults = this._Model.GetEndResultDivers();
            this._Spectatorform.endResult = endResults;

        }

        public void UpdateJumps()
        {
            if (this._Model.CheckCompetitionDone(_diverform.diver))
            {
                // If object is null, this competition is done.
                this._diverform.jump_updater_backgroundWorker.ReportProgress(0, null);
            }

            List <Jump> newJumps = this._Model.UpdateJumps(_diverform.diver.id);
            this._diverform.diver.jumps = newJumps;
            this._diverform.jump_updater_backgroundWorker.ReportProgress(1, newJumps);
        }

        public void GetJumps()
        {

            try
            {
                Tuple<Jump, Diver> newJumpDiver = this._Model.GetJumps(_judgeform.judge.competition, _judgeform.judge.id);
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

        public void CompDone()
        {
            this._diverform.jump_updater_backgroundWorker.CancelAsync();
            this._diverform.Hide();
            this._judgeform.Show();
        }

        public void GetJumpTypes()
        {
            this._diverform.PerformJumpBox.ValueMember = "Id";
            this._diverform.PerformJumpBox.DisplayMember = "Value";
            this._diverform.PerformJumpBox.DataSource = new System.Windows.Forms.BindingSource(this._Model.GetJumpTypes(), null);
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
                    GetJumpTypes();
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

            int thisJumpStyle = ((System.Collections.Generic.KeyValuePair<int, string>)_diverform.PerformJumpBox.SelectedItem).Key;

            this._Model.Jump(_diverform.diver, thisJumpStyle, Convert.ToInt32(_diverform.DifficultyBox.Text));
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
