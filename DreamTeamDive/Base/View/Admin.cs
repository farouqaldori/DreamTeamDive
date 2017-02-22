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
        public event DelegateDeleteJudge EventDeleteJudge = null;
        public event DelegateDeleteDiver EventDeleteDiver = null;
        public event DelegateWriteToFileDiver EventWriteToFileDiver = null;
        public event DelegateWriteToFileJudge EventWriteToFileJudge = null;
        public event DelegateReadFromFileDiver EventReadFromFileDiver = null;
        public event DelegateReadFromFileJudge EventReadFromFileJudge = null;
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
            this.JudgeGridView.Columns[2].Visible = false;
            this.JudgeGridView.Columns[3].Visible = false;
            this.DiverGridView.Columns[2].Visible = false;
            this.DiverGridView.Columns[3].Visible = false;
            this.DiverGridView.Columns[4].Visible = false;
            this.DiverGridView.Columns[5].Visible = false;
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
            if (Reset_Button.Enabled)
            {
                CompetitionName_TextBox.Text = "<Name>";
                ID__TextBox.Text = "<ID>";
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
        
        private void DeleteDiver_Button_Click(object sender, EventArgs e)
        {
            // Checks which row is choosen and remove it
            try
            {
                if (this._DiverRow != -1)
                    if (this.EventDeleteDiver != null)
                        this.EventDeleteDiver(this._DiverRow);
                this._DiverRow = DiverGridView.SelectedRows.Count;
            }
            catch
            {
                MessageBox.Show("Try again!", "Waring");
            }
        }

        private void AddDiver_Button_Click(object sender, EventArgs e)
        {
            if (this.EventUpdateDiverGridTable != null)
                this.EventUpdateDiverGridTable();
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
            this.JudgeGridView.Rows.Clear();
            for (int i = 0; i<5;i++)
            {
                if (this.EventUpdateJudgeGridTable != null)
                    this.EventUpdateJudgeGridTable();
            }
            if (this.JudgeGridView.Rows.Count > MaxJudgeRowCount)
            {
                this.JudgeGridView.AllowUserToAddRows = false;
            }
            else
            {
                this.JudgeGridView.AllowUserToAddRows = true;
            }
        }

        private void Judges_Seven_Check_CheckedChanged(object sender, EventArgs e)
        {
            int MaxJudgeRowCount = 7;
            this.JudgeGridView.Rows.Clear();
            for (int i = 0; i < 7; i++)
            {
                if (this.EventUpdateJudgeGridTable != null)
                    this.EventUpdateJudgeGridTable();
            }
            if (this.JudgeGridView.Rows.Count > MaxJudgeRowCount)
            {
                this.JudgeGridView.AllowUserToAddRows = false;
            }
            else
            {
                this.JudgeGridView.AllowUserToAddRows = true;
            }
        }
    }
}