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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.Reset_Button = new MetroFramework.Controls.MetroButton();
            this.Create_Button = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.Judges_Seven_Check = new MetroFramework.Controls.MetroRadioButton();
            this.Judges_Five_Check = new MetroFramework.Controls.MetroRadioButton();
            this.CompetitionName_TextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.JudgeGridView = new System.Windows.Forms.DataGridView();
            this.SaveToFileJudge_button = new MetroFramework.Controls.MetroButton();
            this.ReadFromFileJudge_Button = new MetroFramework.Controls.MetroButton();
            this.SaveToFileDiver_Button = new MetroFramework.Controls.MetroButton();
            this.ReadFromfileDiver_Button = new MetroFramework.Controls.MetroButton();
            this.DiverGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JudgeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiverGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(34, 838);
            this.Reset_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(962, 58);
            this.Reset_Button.TabIndex = 44;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseSelectable = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Create_Button
            // 
            this.Create_Button.Location = new System.Drawing.Point(36, 771);
            this.Create_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Create_Button.Name = "Create_Button";
            this.Create_Button.Size = new System.Drawing.Size(960, 58);
            this.Create_Button.TabIndex = 43;
            this.Create_Button.Text = "Create";
            this.Create_Button.UseSelectable = true;
            this.Create_Button.Click += new System.EventHandler(this.Create_Button_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(14, 112);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 42;
            this.metroLabel3.Text = "Date:";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(94, 105);
            this.metroDateTime1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(292, 29);
            this.metroDateTime1.TabIndex = 41;
            // 
            // Judges_Seven_Check
            // 
            this.Judges_Seven_Check.AutoSize = true;
            this.Judges_Seven_Check.Location = new System.Drawing.Point(579, 49);
            this.Judges_Seven_Check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Judges_Seven_Check.Name = "Judges_Seven_Check";
            this.Judges_Seven_Check.Size = new System.Drawing.Size(29, 15);
            this.Judges_Seven_Check.TabIndex = 40;
            this.Judges_Seven_Check.Text = "7";
            this.Judges_Seven_Check.UseSelectable = true;
            this.Judges_Seven_Check.CheckedChanged += new System.EventHandler(this.Judges_Seven_Check_CheckedChanged);
            this.Judges_Seven_Check.Click += new System.EventHandler(this.Judges_Seven_Check_CheckedChanged);
            // 
            // Judges_Five_Check
            // 
            this.Judges_Five_Check.AutoSize = true;
            this.Judges_Five_Check.Location = new System.Drawing.Point(525, 49);
            this.Judges_Five_Check.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Judges_Five_Check.Name = "Judges_Five_Check";
            this.Judges_Five_Check.Size = new System.Drawing.Size(29, 15);
            this.Judges_Five_Check.TabIndex = 39;
            this.Judges_Five_Check.Text = "5";
            this.Judges_Five_Check.UseSelectable = true;
            this.Judges_Five_Check.CheckedChanged += new System.EventHandler(this.Judges_Five_Check_CheckedChanged);
            this.Judges_Five_Check.Click += new System.EventHandler(this.Judges_Five_Check_CheckedChanged);
            // 
            // CompetitionName_TextBox
            // 
            // 
            // 
            // 
            this.CompetitionName_TextBox.CustomButton.Image = null;
            this.CompetitionName_TextBox.CustomButton.Location = new System.Drawing.Point(375, 2);
            this.CompetitionName_TextBox.CustomButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CompetitionName_TextBox.CustomButton.Name = "";
            this.CompetitionName_TextBox.CustomButton.Size = new System.Drawing.Size(64, 66);
            this.CompetitionName_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CompetitionName_TextBox.CustomButton.TabIndex = 1;
            this.CompetitionName_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CompetitionName_TextBox.CustomButton.UseSelectable = true;
            this.CompetitionName_TextBox.CustomButton.Visible = false;
            this.CompetitionName_TextBox.Lines = new string[0];
            this.CompetitionName_TextBox.Location = new System.Drawing.Point(94, 35);
            this.CompetitionName_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CompetitionName_TextBox.MaxLength = 32767;
            this.CompetitionName_TextBox.Name = "CompetitionName_TextBox";
            this.CompetitionName_TextBox.PasswordChar = '\0';
            this.CompetitionName_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CompetitionName_TextBox.SelectedText = "";
            this.CompetitionName_TextBox.SelectionLength = 0;
            this.CompetitionName_TextBox.SelectionStart = 0;
            this.CompetitionName_TextBox.ShortcutsEnabled = true;
            this.CompetitionName_TextBox.Size = new System.Drawing.Size(294, 45);
            this.CompetitionName_TextBox.TabIndex = 38;
            this.CompetitionName_TextBox.UseSelectable = true;
            this.CompetitionName_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CompetitionName_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(434, 43);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 37;
            this.metroLabel2.Text = "Judges:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 43);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 36;
            this.metroLabel1.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.CompetitionName_TextBox);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroDateTime1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.Judges_Five_Check);
            this.groupBox1.Controls.Add(this.Judges_Seven_Check);
            this.groupBox1.Location = new System.Drawing.Point(36, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(960, 175);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contest Information";
            // 
            // JudgeGridView
            // 
            this.JudgeGridView.AllowUserToResizeColumns = false;
            this.JudgeGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            this.JudgeGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.JudgeGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.JudgeGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.JudgeGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.JudgeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.JudgeGridView.DefaultCellStyle = dataGridViewCellStyle13;
            this.JudgeGridView.Location = new System.Drawing.Point(9, 29);
            this.JudgeGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JudgeGridView.Name = "JudgeGridView";
            this.JudgeGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.JudgeGridView.Size = new System.Drawing.Size(452, 340);
            this.JudgeGridView.TabIndex = 46;
            this.JudgeGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.JudgeGridView_CellClick);
            // 
            // SaveToFileJudge_button
            // 
            this.SaveToFileJudge_button.Location = new System.Drawing.Point(9, 378);
            this.SaveToFileJudge_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveToFileJudge_button.Name = "SaveToFileJudge_button";
            this.SaveToFileJudge_button.Size = new System.Drawing.Size(142, 58);
            this.SaveToFileJudge_button.TabIndex = 51;
            this.SaveToFileJudge_button.Text = "Save to file";
            this.SaveToFileJudge_button.UseSelectable = true;
            this.SaveToFileJudge_button.Click += new System.EventHandler(this.SaveToFileJudge_button_Click);
            // 
            // ReadFromFileJudge_Button
            // 
            this.ReadFromFileJudge_Button.Location = new System.Drawing.Point(160, 378);
            this.ReadFromFileJudge_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReadFromFileJudge_Button.Name = "ReadFromFileJudge_Button";
            this.ReadFromFileJudge_Button.Size = new System.Drawing.Size(142, 58);
            this.ReadFromFileJudge_Button.TabIndex = 52;
            this.ReadFromFileJudge_Button.Text = "Read from file";
            this.ReadFromFileJudge_Button.UseSelectable = true;
            this.ReadFromFileJudge_Button.Click += new System.EventHandler(this.ReadFromFileJudge_Button_Click);
            // 
            // SaveToFileDiver_Button
            // 
            this.SaveToFileDiver_Button.Location = new System.Drawing.Point(14, 378);
            this.SaveToFileDiver_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveToFileDiver_Button.Name = "SaveToFileDiver_Button";
            this.SaveToFileDiver_Button.Size = new System.Drawing.Size(142, 58);
            this.SaveToFileDiver_Button.TabIndex = 56;
            this.SaveToFileDiver_Button.Text = "Save to file";
            this.SaveToFileDiver_Button.UseSelectable = true;
            this.SaveToFileDiver_Button.Click += new System.EventHandler(this.SaveToFileDiver_Button_Click);
            // 
            // ReadFromfileDiver_Button
            // 
            this.ReadFromfileDiver_Button.Location = new System.Drawing.Point(165, 378);
            this.ReadFromfileDiver_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReadFromfileDiver_Button.Name = "ReadFromfileDiver_Button";
            this.ReadFromfileDiver_Button.Size = new System.Drawing.Size(142, 58);
            this.ReadFromfileDiver_Button.TabIndex = 57;
            this.ReadFromfileDiver_Button.Text = "Read from file";
            this.ReadFromfileDiver_Button.UseSelectable = true;
            this.ReadFromfileDiver_Button.Click += new System.EventHandler(this.ReadFromfileDiver_Button_Click);
            // 
            // DiverGridView
            // 
            this.DiverGridView.AllowUserToResizeColumns = false;
            this.DiverGridView.AllowUserToResizeRows = false;
            this.DiverGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DiverGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiverGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DiverGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DiverGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DiverGridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.DiverGridView.Location = new System.Drawing.Point(14, 29);
            this.DiverGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DiverGridView.Name = "DiverGridView";
            this.DiverGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DiverGridView.Size = new System.Drawing.Size(453, 340);
            this.DiverGridView.TabIndex = 55;
            this.DiverGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiverGridView_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DiverGridView);
            this.groupBox2.Controls.Add(this.SaveToFileDiver_Button);
            this.groupBox2.Controls.Add(this.ReadFromfileDiver_Button);
            this.groupBox2.Location = new System.Drawing.Point(36, 285);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(476, 460);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diver List";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SaveToFileJudge_button);
            this.groupBox3.Controls.Add(this.ReadFromFileJudge_Button);
            this.groupBox3.Controls.Add(this.JudgeGridView);
            this.groupBox3.Location = new System.Drawing.Point(526, 285);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(470, 460);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Judge Box";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 920);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Create_Button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Resizable = false;
            this.Text = "Create a new contest";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JudgeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiverGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        public MetroFramework.Controls.MetroButton Reset_Button;
        public MetroFramework.Controls.MetroButton Create_Button;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        public MetroFramework.Controls.MetroDateTime metroDateTime1;
        public MetroFramework.Controls.MetroRadioButton Judges_Seven_Check;
        public MetroFramework.Controls.MetroRadioButton Judges_Five_Check;
        public MetroFramework.Controls.MetroTextBox CompetitionName_TextBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        public MetroFramework.Controls.MetroButton SaveToFileJudge_button;
        public MetroFramework.Controls.MetroButton ReadFromFileJudge_Button;
        public System.Windows.Forms.DataGridView JudgeGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView DiverGridView;
        public MetroFramework.Controls.MetroButton SaveToFileDiver_Button;
        public MetroFramework.Controls.MetroButton ReadFromfileDiver_Button;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

