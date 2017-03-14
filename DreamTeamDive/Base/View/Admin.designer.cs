namespace Diver_Contest
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.contest_tab = new MetroFramework.Controls.MetroTabPage();
            this.Reset_Button = new MetroFramework.Controls.MetroButton();
            this.Create_Button = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.Judges_Seven_Check = new MetroFramework.Controls.MetroRadioButton();
            this.Judges_Five_Check = new MetroFramework.Controls.MetroRadioButton();
            this.CompetitionName_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.judge_tab = new MetroFramework.Controls.MetroTabPage();
            this.ReadFromFileJudge_Button = new MetroFramework.Controls.MetroButton();
            this.SaveToFileJudge_button = new MetroFramework.Controls.MetroButton();
            this.JudgeGridView = new System.Windows.Forms.DataGridView();
            this.Diver_tab = new MetroFramework.Controls.MetroTabPage();
            this.ReadFromfileDiver_Button = new MetroFramework.Controls.MetroButton();
            this.SaveToFileDiver_Button = new MetroFramework.Controls.MetroButton();
            this.DiverGridView = new System.Windows.Forms.DataGridView();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.contest_tab.SuspendLayout();
            this.judge_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JudgeGridView)).BeginInit();
            this.Diver_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiverGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.contest_tab);
            this.metroTabControl1.Controls.Add(this.judge_tab);
            this.metroTabControl1.Controls.Add(this.Diver_tab);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 76);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(426, 433);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // contest_tab
            // 
            this.contest_tab.Controls.Add(this.Reset_Button);
            this.contest_tab.Controls.Add(this.Create_Button);
            this.contest_tab.Controls.Add(this.metroLabel3);
            this.contest_tab.Controls.Add(this.metroDateTime1);
            this.contest_tab.Controls.Add(this.Judges_Seven_Check);
            this.contest_tab.Controls.Add(this.Judges_Five_Check);
            this.contest_tab.Controls.Add(this.CompetitionName_TextBox);
            this.contest_tab.Controls.Add(this.metroLabel2);
            this.contest_tab.Controls.Add(this.metroLabel1);
            this.contest_tab.HorizontalScrollbarBarColor = true;
            this.contest_tab.HorizontalScrollbarHighlightOnWheel = false;
            this.contest_tab.HorizontalScrollbarSize = 10;
            this.contest_tab.Location = new System.Drawing.Point(4, 38);
            this.contest_tab.Name = "contest_tab";
            this.contest_tab.Size = new System.Drawing.Size(418, 391);
            this.contest_tab.TabIndex = 0;
            this.contest_tab.Text = "Contest";
            this.contest_tab.VerticalScrollbarBarColor = true;
            this.contest_tab.VerticalScrollbarHighlightOnWheel = false;
            this.contest_tab.VerticalScrollbarSize = 10;
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(160, 235);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(95, 38);
            this.Reset_Button.TabIndex = 13;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseSelectable = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Create_Button
            // 
            this.Create_Button.Location = new System.Drawing.Point(59, 235);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(95, 38);
            this.Create_Button.TabIndex = 12;
            this.Create_Button.Text = "Create";
            this.Create_Button.UseSelectable = true;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 159);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Date:";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(59, 155);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(196, 29);
            this.metroDateTime1.TabIndex = 10;
            this.metroDateTime1.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // Judges_Seven_Check
            // 
            this.Judges_Seven_Check.AutoSize = true;
            this.Judges_Seven_Check.Location = new System.Drawing.Point(125, 109);
            this.Judges_Seven_Check.Name = "Judges_Seven_Check";
            this.Judges_Seven_Check.Size = new System.Drawing.Size(29, 15);
            this.Judges_Seven_Check.TabIndex = 7;
            this.Judges_Seven_Check.Text = "7";
            this.Judges_Seven_Check.UseSelectable = true;
            this.Judges_Seven_Check.CheckedChanged += new System.EventHandler(this.Judges_Seven_Check_CheckedChanged);
            // 
            // Judges_Five_Check
            // 
            this.Judges_Five_Check.AutoSize = true;
            this.Judges_Five_Check.Location = new System.Drawing.Point(64, 109);
            this.Judges_Five_Check.Name = "Judges_Five_Check";
            this.Judges_Five_Check.Size = new System.Drawing.Size(29, 15);
            this.Judges_Five_Check.TabIndex = 6;
            this.Judges_Five_Check.Text = "5";
            this.Judges_Five_Check.UseSelectable = true;
            this.Judges_Five_Check.CheckedChanged += new System.EventHandler(this.Judges_Five_Check_CheckedChanged);
            // 
            // CompetitionName_TextBox
            // 
            // 
            // 
            // 
            this.CompetitionName_TextBox.CustomButton.Image = null;
            this.CompetitionName_TextBox.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.CompetitionName_TextBox.CustomButton.Name = "";
            this.CompetitionName_TextBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.CompetitionName_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CompetitionName_TextBox.CustomButton.TabIndex = 1;
            this.CompetitionName_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CompetitionName_TextBox.CustomButton.UseSelectable = true;
            this.CompetitionName_TextBox.CustomButton.Visible = false;
            this.CompetitionName_TextBox.Lines = new string[] {
        "<Name>"};
            this.CompetitionName_TextBox.Location = new System.Drawing.Point(59, 51);
            this.CompetitionName_TextBox.MaxLength = 32767;
            this.CompetitionName_TextBox.Name = "CompetitionName_TextBox";
            this.CompetitionName_TextBox.PasswordChar = '\0';
            this.CompetitionName_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CompetitionName_TextBox.SelectedText = "";
            this.CompetitionName_TextBox.SelectionLength = 0;
            this.CompetitionName_TextBox.SelectionStart = 0;
            this.CompetitionName_TextBox.ShortcutsEnabled = true;
            this.CompetitionName_TextBox.Size = new System.Drawing.Size(196, 29);
            this.CompetitionName_TextBox.TabIndex = 5;
            this.CompetitionName_TextBox.Text = "<Name>";
            this.CompetitionName_TextBox.UseSelectable = true;
            this.CompetitionName_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CompetitionName_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 105);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Judges:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 51);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Name:";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // judge_tab
            // 
            this.judge_tab.Controls.Add(this.ReadFromFileJudge_Button);
            this.judge_tab.Controls.Add(this.SaveToFileJudge_button);
            this.judge_tab.Controls.Add(this.JudgeGridView);
            this.judge_tab.HorizontalScrollbarBarColor = true;
            this.judge_tab.HorizontalScrollbarHighlightOnWheel = false;
            this.judge_tab.HorizontalScrollbarSize = 10;
            this.judge_tab.Location = new System.Drawing.Point(4, 38);
            this.judge_tab.Name = "judge_tab";
            this.judge_tab.Size = new System.Drawing.Size(418, 391);
            this.judge_tab.TabIndex = 1;
            this.judge_tab.Text = "Judge";
            this.judge_tab.VerticalScrollbarBarColor = true;
            this.judge_tab.VerticalScrollbarHighlightOnWheel = false;
            this.judge_tab.VerticalScrollbarSize = 10;
            this.judge_tab.Click += new System.EventHandler(this.judge_tab_Click);
            // 
            // ReadFromFileJudge_Button
            // 
            this.ReadFromFileJudge_Button.Location = new System.Drawing.Point(104, 327);
            this.ReadFromFileJudge_Button.Name = "ReadFromFileJudge_Button";
            this.ReadFromFileJudge_Button.Size = new System.Drawing.Size(95, 38);
            this.ReadFromFileJudge_Button.TabIndex = 29;
            this.ReadFromFileJudge_Button.Text = "Read from file";
            this.ReadFromFileJudge_Button.UseSelectable = true;
            this.ReadFromFileJudge_Button.Click += new System.EventHandler(this.ReadFromFileJudge_Button_Click);
            // 
            // SaveToFileJudge_button
            // 
            this.SaveToFileJudge_button.Location = new System.Drawing.Point(3, 327);
            this.SaveToFileJudge_button.Name = "SaveToFileJudge_button";
            this.SaveToFileJudge_button.Size = new System.Drawing.Size(95, 38);
            this.SaveToFileJudge_button.TabIndex = 28;
            this.SaveToFileJudge_button.Text = "Save to file";
            this.SaveToFileJudge_button.UseSelectable = true;
            this.SaveToFileJudge_button.Click += new System.EventHandler(this.SaveToFileJudge_button_Click);
            // 
            // JudgeGridView
            // 
            this.JudgeGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.JudgeGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.JudgeGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.JudgeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.JudgeGridView.Location = new System.Drawing.Point(0, 3);
            this.JudgeGridView.Name = "JudgeGridView";
            this.JudgeGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.JudgeGridView.Size = new System.Drawing.Size(418, 318);
            this.JudgeGridView.TabIndex = 19;
            this.JudgeGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JudgeGridView_CellClick);
            // 
            // Diver_tab
            // 
            this.Diver_tab.Controls.Add(this.ReadFromfileDiver_Button);
            this.Diver_tab.Controls.Add(this.SaveToFileDiver_Button);
            this.Diver_tab.Controls.Add(this.DiverGridView);
            this.Diver_tab.HorizontalScrollbarBarColor = true;
            this.Diver_tab.HorizontalScrollbarHighlightOnWheel = false;
            this.Diver_tab.HorizontalScrollbarSize = 10;
            this.Diver_tab.Location = new System.Drawing.Point(4, 38);
            this.Diver_tab.Name = "Diver_tab";
            this.Diver_tab.Size = new System.Drawing.Size(418, 391);
            this.Diver_tab.TabIndex = 2;
            this.Diver_tab.Text = "Diver";
            this.Diver_tab.VerticalScrollbarBarColor = true;
            this.Diver_tab.VerticalScrollbarHighlightOnWheel = false;
            this.Diver_tab.VerticalScrollbarSize = 10;
            this.Diver_tab.Click += new System.EventHandler(this.Hopper_tab_Click);
            // 
            // ReadFromfileDiver_Button
            // 
            this.ReadFromfileDiver_Button.Location = new System.Drawing.Point(104, 327);
            this.ReadFromfileDiver_Button.Name = "ReadFromfileDiver_Button";
            this.ReadFromfileDiver_Button.Size = new System.Drawing.Size(95, 38);
            this.ReadFromfileDiver_Button.TabIndex = 27;
            this.ReadFromfileDiver_Button.Text = "Read from file";
            this.ReadFromfileDiver_Button.UseSelectable = true;
            this.ReadFromfileDiver_Button.Click += new System.EventHandler(this.ReadFromfileDiver_Button_Click);
            // 
            // SaveToFileDiver_Button
            // 
            this.SaveToFileDiver_Button.Location = new System.Drawing.Point(3, 327);
            this.SaveToFileDiver_Button.Name = "SaveToFileDiver_Button";
            this.SaveToFileDiver_Button.Size = new System.Drawing.Size(95, 38);
            this.SaveToFileDiver_Button.TabIndex = 26;
            this.SaveToFileDiver_Button.Text = "Save to file";
            this.SaveToFileDiver_Button.UseSelectable = true;
            this.SaveToFileDiver_Button.Click += new System.EventHandler(this.SaveToFileDiver_Button_Click);
            // 
            // DiverGridView
            // 
            this.DiverGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DiverGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DiverGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DiverGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DiverGridView.Location = new System.Drawing.Point(0, 3);
            this.DiverGridView.Name = "DiverGridView";
            this.DiverGridView.Size = new System.Drawing.Size(418, 318);
            this.DiverGridView.TabIndex = 20;
            this.DiverGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiverGridView_CellClick);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 534);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Admin";
            this.Text = "Welcome,";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.contest_tab.ResumeLayout(false);
            this.contest_tab.PerformLayout();
            this.judge_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.JudgeGridView)).EndInit();
            this.Diver_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DiverGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage contest_tab;
        private MetroFramework.Controls.MetroTabPage judge_tab;
        private MetroFramework.Controls.MetroTabPage Diver_tab;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroRadioButton Judges_Seven_Check;
        public MetroFramework.Controls.MetroRadioButton Judges_Five_Check;
        public MetroFramework.Controls.MetroDateTime metroDateTime1;
        public MetroFramework.Controls.MetroButton Reset_Button;
        public MetroFramework.Controls.MetroButton Create_Button;
        public MetroFramework.Controls.MetroTextBox CompetitionName_TextBox;
        public System.Windows.Forms.DataGridView JudgeGridView;
        public System.Windows.Forms.DataGridView DiverGridView;
        public MetroFramework.Controls.MetroButton ReadFromFileJudge_Button;
        public MetroFramework.Controls.MetroButton SaveToFileJudge_button;
        public MetroFramework.Controls.MetroButton ReadFromfileDiver_Button;
        public MetroFramework.Controls.MetroButton SaveToFileDiver_Button;
    }
}

