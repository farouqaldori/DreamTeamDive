using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace Diver_Contest
{
    public partial class Admin : MetroFramework.Forms.MetroForm, IAdminForm
    {
        private int _DiverRow = -1;
        private int _JudgeRow = -1;
        public event DelegateUpdateJudgeGridTable EventUpdateJudgeGridTable = null;
        public event DelegateUpdateDiverGridTable EventUpdateDiverGridTable = null;
        public event DelegateWriteToFileDiver EventWriteToFileDiver = null;
        public event DelegateWriteToFileJudge EventWriteToFileJudge = null;
        public event DelegateReadFromFileDiver EventReadFromFileDiver = null;
        public event DelegateReadFromFileJudge EventReadFromFileJudge = null;
        public event DelegateCreateNewCompetition EventCreateNewCompetition = null;
        public event DelegateInsertNewDivers EventInsertNewDivers = null;
        public event DelegateInsertNewJudges EventInsertNewJudges = null;
        public Admin()
        {
            InitializeComponent();
            this.StyleManager = msmMain;

        }

        void IAdminForm.SetDiversList(Collection<Diver> divers)
        {
            this.DiverGridView.DataSource = divers;
        }

        void IAdminForm.SetJudgesList(Collection<Judge> judges)
        {
            this.JudgeGridView.DataSource = judges;
        }


        private void Main_Load(object sender, EventArgs e)
        {
            // Hide Judge information.
            this.JudgeGridView.Columns[2].Visible = false;
            
            // Hide Diver information.
            this.DiverGridView.Columns[2].Visible = false;
            this.DiverGridView.Columns[4].Visible = false;
            this.DiverGridView.Columns[6].Visible = false;

            // Make the Authentication Code readonly.
            this.JudgeGridView.Columns[3].ReadOnly = true;
            this.DiverGridView.Columns[5].ReadOnly = true;
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Hopper_tab_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            // Reset all changes in form.
            if (Reset_Button.Enabled)
            {
                CompetitionName_TextBox.Text = "<Name>";
                Judges_Five_Check.Checked = false;
                Judges_Seven_Check.Checked = false;
                metroDateTime1.Value = DateTime.Today;
            }
        }
    
        private void JudgeGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._JudgeRow = e.RowIndex;
        }
        private void DiverGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._DiverRow = e.RowIndex;
        }

        private void judge_tab_Click(object sender, EventArgs e)
        {

        }

        private void SaveToFileJudge_button_Click(object sender, EventArgs e)
        {
            if (this.EventWriteToFileJudge != null)
                this.EventWriteToFileJudge();
        }

        private void ReadFromFileJudge_Button_Click(object sender, EventArgs e)
        {
            if (this.EventReadFromFileJudge != null)
                this.EventReadFromFileJudge();
        }

        private void SaveToFileDiver_Button_Click(object sender, EventArgs e)
        {
            if (this.EventWriteToFileDiver != null)
                this.EventWriteToFileDiver();
        }

        private void ReadFromfileDiver_Button_Click(object sender, EventArgs e)
        {
            if (this.EventReadFromFileDiver != null)
                this.EventReadFromFileDiver();
        }

        private void Judges_Five_Check_CheckedChanged(object sender, EventArgs e)
        {
            int MaxJudgeRowCount = 5;
            int MaxDiverRowCount = 6;
            this.JudgeGridView.Rows.Clear();
            this.DiverGridView.Rows.Clear();
            for (int i = 0; i< 5; i++)
            {
                if (this.EventUpdateJudgeGridTable != null)
                    this.EventUpdateJudgeGridTable();
            }
            for (int i = 0; i < 6; i++)
            {
                if (this.EventUpdateDiverGridTable != null)
                    this.EventUpdateDiverGridTable();
            }
            if (this.JudgeGridView.Rows.Count > MaxJudgeRowCount && this.DiverGridView.Rows.Count > MaxDiverRowCount)
            {
                this.JudgeGridView.AllowUserToAddRows = false;
                this.DiverGridView.AllowUserToAddRows = false;
            }
            else
            {
                this.JudgeGridView.AllowUserToAddRows = true;
                this.DiverGridView.AllowUserToAddRows = true;
            }
        }

        private void Judges_Seven_Check_CheckedChanged(object sender, EventArgs e)
        {
            int MaxJudgeRowCount = 7;
            int MaxDiverRowCount = 10;
            this.JudgeGridView.Rows.Clear();
            this.DiverGridView.Rows.Clear();
            for (int i = 0; i < 7; i++)
            {
                if (this.EventUpdateJudgeGridTable != null)
                    this.EventUpdateJudgeGridTable();
            }
            for (int i = 0; i < 10; i++)
            {
                if (this.EventUpdateDiverGridTable != null)
                    this.EventUpdateDiverGridTable();
            }
            if (this.JudgeGridView.Rows.Count > MaxJudgeRowCount && this.DiverGridView.Rows.Count > MaxDiverRowCount)
            {
                this.JudgeGridView.AllowUserToAddRows = false;
                this.DiverGridView.AllowUserToAddRows = false;
            }
            else
            {
                this.JudgeGridView.AllowUserToAddRows = true;
                this.DiverGridView.AllowUserToAddRows = true;
            }
        }

        private void Create_Button_Click(object sender, EventArgs e)
        {
            this.Create_Button.Enabled = false;
            if (this.EventCreateNewCompetition != null)
                this.EventCreateNewCompetition(CompetitionName_TextBox.Text.ToString(), metroDateTime1.Text.ToString());

            if (this.EventInsertNewDivers != null)
                this.EventInsertNewDivers(DiverGridView.RowCount);

            if (this.EventInsertNewJudges != null)
                this.EventInsertNewJudges(JudgeGridView.RowCount);

            this.Create_Button.Enabled = true;
        }
    }
}