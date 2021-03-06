﻿namespace Diver_Contest
{
    partial class diver_form
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
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.JumpButton = new MetroFramework.Controls.MetroButton();
            this.PerformJumpBox = new MetroFramework.Controls.MetroComboBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.DifficultyBox = new MetroFramework.Controls.MetroComboBox();
            this.jump_updater_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.Jump1Label = new System.Windows.Forms.Label();
            this.Jump2Label = new System.Windows.Forms.Label();
            this.Jump3Label = new System.Windows.Forms.Label();
            this.Jump4Label = new System.Windows.Forms.Label();
            this.Jump5Label = new System.Windows.Forms.Label();
            this.Jump6Label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.Location = new System.Drawing.Point(12, 37);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(60, 15);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Jump Style";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.Location = new System.Drawing.Point(12, 129);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(68, 15);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Set Difficulity";
            // 
            // JumpButton
            // 
            this.JumpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.JumpButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.JumpButton.Location = new System.Drawing.Point(238, 65);
            this.JumpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JumpButton.Name = "JumpButton";
            this.JumpButton.Size = new System.Drawing.Size(159, 135);
            this.JumpButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.JumpButton.TabIndex = 3;
            this.JumpButton.Text = "Jump";
            this.JumpButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.JumpButton, "Send Jump!");
            this.JumpButton.UseSelectable = true;
            this.JumpButton.Click += new System.EventHandler(this.Jump_Click);
            // 
            // PerformJumpBox
            // 
            this.PerformJumpBox.FormattingEnabled = true;
            this.PerformJumpBox.ItemHeight = 23;
            this.PerformJumpBox.Items.AddRange(new object[] {
            "101A",
            "112B",
            "200C",
            "213D",
            "315D",
            "302A",
            "412C",
            "403B",
            "------",
            "5211A",
            "5337D",
            "------",
            "600A",
            "624C",
            "------",
            "6432D",
            "6311A"});
            this.PerformJumpBox.Location = new System.Drawing.Point(12, 65);
            this.PerformJumpBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PerformJumpBox.Name = "PerformJumpBox";
            this.PerformJumpBox.Size = new System.Drawing.Size(200, 29);
            this.PerformJumpBox.TabIndex = 1;
            this.PerformJumpBox.UseSelectable = true;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // DifficultyBox
            // 
            this.DifficultyBox.FormattingEnabled = true;
            this.DifficultyBox.ItemHeight = 23;
            this.DifficultyBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.DifficultyBox.Location = new System.Drawing.Point(12, 155);
            this.DifficultyBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DifficultyBox.Name = "DifficultyBox";
            this.DifficultyBox.Size = new System.Drawing.Size(200, 29);
            this.DifficultyBox.TabIndex = 2;
            this.DifficultyBox.UseSelectable = true;
            // 
            // jump_updater_backgroundWorker
            // 
            this.jump_updater_backgroundWorker.WorkerReportsProgress = true;
            this.jump_updater_backgroundWorker.WorkerSupportsCancellation = true;
            this.jump_updater_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.jump_updater_backgroundWorker_DoWork);
            this.jump_updater_backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.jump_updater_backgroundWorker_ProgressChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(9, 38);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Jump 1:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(9, 91);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Jump 2:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(9, 143);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Jump 3:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(242, 38);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(57, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Jump 4:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(242, 91);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(57, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Jump 5:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(242, 143);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(57, 19);
            this.metroLabel6.TabIndex = 5;
            this.metroLabel6.Text = "Jump 6:";
            // 
            // Jump1Label
            // 
            this.Jump1Label.AutoSize = true;
            this.Jump1Label.Location = new System.Drawing.Point(94, 46);
            this.Jump1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Jump1Label.Name = "Jump1Label";
            this.Jump1Label.Size = new System.Drawing.Size(68, 20);
            this.Jump1Label.TabIndex = 11;
            this.Jump1Label.Text = "loading..";
            this.Jump1Label.Click += new System.EventHandler(this.Jump1Label_Click);
            // 
            // Jump2Label
            // 
            this.Jump2Label.AutoSize = true;
            this.Jump2Label.Location = new System.Drawing.Point(94, 98);
            this.Jump2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Jump2Label.Name = "Jump2Label";
            this.Jump2Label.Size = new System.Drawing.Size(68, 20);
            this.Jump2Label.TabIndex = 12;
            this.Jump2Label.Text = "loading..";
            // 
            // Jump3Label
            // 
            this.Jump3Label.AutoSize = true;
            this.Jump3Label.Location = new System.Drawing.Point(94, 151);
            this.Jump3Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Jump3Label.Name = "Jump3Label";
            this.Jump3Label.Size = new System.Drawing.Size(68, 20);
            this.Jump3Label.TabIndex = 13;
            this.Jump3Label.Text = "loading..";
            // 
            // Jump4Label
            // 
            this.Jump4Label.AutoSize = true;
            this.Jump4Label.Location = new System.Drawing.Point(327, 46);
            this.Jump4Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Jump4Label.Name = "Jump4Label";
            this.Jump4Label.Size = new System.Drawing.Size(68, 20);
            this.Jump4Label.TabIndex = 14;
            this.Jump4Label.Text = "loading..";
            // 
            // Jump5Label
            // 
            this.Jump5Label.AutoSize = true;
            this.Jump5Label.Location = new System.Drawing.Point(327, 98);
            this.Jump5Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Jump5Label.Name = "Jump5Label";
            this.Jump5Label.Size = new System.Drawing.Size(68, 20);
            this.Jump5Label.TabIndex = 15;
            this.Jump5Label.Text = "loading..";
            // 
            // Jump6Label
            // 
            this.Jump6Label.AutoSize = true;
            this.Jump6Label.Location = new System.Drawing.Point(327, 151);
            this.Jump6Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Jump6Label.Name = "Jump6Label";
            this.Jump6Label.Size = new System.Drawing.Size(68, 20);
            this.Jump6Label.TabIndex = 16;
            this.Jump6Label.Text = "loading..";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.Jump6Label);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.Jump5Label);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.Jump4Label);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.Jump3Label);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.Jump2Label);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.Jump1Label);
            this.groupBox1.Location = new System.Drawing.Point(36, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(423, 205);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jump List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.JumpButton);
            this.groupBox2.Controls.Add(this.PerformJumpBox);
            this.groupBox2.Controls.Add(this.metroLabel8);
            this.groupBox2.Controls.Add(this.DifficultyBox);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Location = new System.Drawing.Point(36, 323);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(423, 228);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Perform Jump";
            // 
            // diver_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 586);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "diver_form";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Resizable = false;
            this.Text = "Diver";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        public MetroFramework.Controls.MetroButton JumpButton;
        public System.ComponentModel.BackgroundWorker jump_updater_backgroundWorker;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        public System.Windows.Forms.Label Jump1Label;
        public System.Windows.Forms.Label Jump2Label;
        public System.Windows.Forms.Label Jump3Label;
        public System.Windows.Forms.Label Jump4Label;
        public System.Windows.Forms.Label Jump5Label;
        public System.Windows.Forms.Label Jump6Label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public MetroFramework.Controls.MetroComboBox PerformJumpBox;
        public MetroFramework.Controls.MetroComboBox DifficultyBox;
    }
}