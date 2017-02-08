using System;
using System.Collections.Generic;
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

        public ICompetition _Model { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="view"></param>
        public PresenterForMain(diver_form diverform, main_auth_form mainform, CompetitionRegister cr)
        {
            this._Model = cr;
            this._mainform = mainform;
            this._diverform = diverform;

            // Start db connection
            this._Model.StartConnection();

            this._mainform.EventLogin += Login;
            this._mainform.EventExit += Exit;
            this._mainform.EventJump += Jump;
            this._diverform.EventUpdateJumps += UpdateJumps;
            
        }

        public void UpdateJumps()
        {
            List <Jump> newJumps = this._Model.UpdateJumps(_diverform.diver.id);
            this._diverform.jump_updater_backgroundWorker.ReportProgress(1, newJumps);
        }

        public void Login()
        {
            this._mainform.authBox.Enabled = false;
            this._mainform.LoginButton.Enabled = false;
            
            string authCode = _mainform.authBox.Text;
            if (_mainform.diver_radio_button.Checked)
            {
                try
                {
                    // Authentication successfull
                    Diver diver = this._Model.Login(authCode);
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
        }

        public void Exit()
        {
            this._Model.Exit();
        }

        public void Jump()
        {
            this._Model.Jump();
        }
    }
}
