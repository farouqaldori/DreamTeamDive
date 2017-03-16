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
        public event DelegateLogin EventLogin = null;
        public event DelegateExit EventExit = null;
        public event DelegateJump EventJump = null;
        public event DelegateUpdateJumps EventUpdateJumps = null;
        public event DelegateSendRating EventSendRating = null;
        public event DelegateGetJump EventGetJump = null;
        public event DelegateGetRatingDivers EventGetRatingDivers = null;
        public event DelegateGetEndResultDivers EventGetEndResultDivers = null;

        public List<Diver> diver;
        public List<Diver> endResult;
        public spectator_form()
        {
            InitializeComponent();
        }

        private void spectator_form_Load(object sender, EventArgs e)
        {
            if (this.EventGetRatingDivers != null)
            {
                EventGetRatingDivers();
            }
            if (this.EventGetEndResultDivers != null)
            {
                EventGetEndResultDivers();
            }
            showStats();
        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void AwaitingLabelMale_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void showStats()
        {
            // Participant name
            m1JumperLabel.Text = diver[0].name.ToString();
            m2JumperLabel.Text = diver[1].name.ToString();
            m3JumperLabel.Text = diver[2].name.ToString();
            m4JumperLabel.Text = diver[3].name.ToString();
            m5JumperLabel.Text = diver[4].name.ToString();
            m6JumperLabel.Text = diver[5].name.ToString();

            //Participant country
            m1CodeLabel.Text = diver[0].country.ToString();
            m2CodeLabel.Text = diver[1].country.ToString();
            m3CodeLabel.Text = diver[2].country.ToString();
            m4CodeLabel.Text = diver[3].country.ToString();
            m5CodeLabel.Text = diver[4].country.ToString();
            m6CodeLabel.Text = diver[5].country.ToString();

            // Position in the game
            mNameLabel1.Text = endResult[0].name.ToString();
            mNameLabel2.Text = endResult[1].name.ToString();
            mNameLabel3.Text = endResult[2].name.ToString();
            mNameLabel4.Text = endResult[3].name.ToString();
            mNameLabel5.Text = endResult[4].name.ToString();
            mNameLabel6.Text = endResult[5].name.ToString();

            // Results
            mResultLabel1.Text = endResult[0].sumGrades.ToString();
            mResultLabel2.Text = endResult[1].sumGrades.ToString();
            mResultLabel3.Text = endResult[2].sumGrades.ToString();
            mResultLabel4.Text = endResult[3].sumGrades.ToString();
            mResultLabel5.Text = endResult[4].sumGrades.ToString();
            mResultLabel6.Text = endResult[5].sumGrades.ToString();
            
        }

    }
}
