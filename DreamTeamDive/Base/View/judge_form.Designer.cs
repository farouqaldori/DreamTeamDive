namespace Diver_Contest
{
    partial class judge_form
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
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.SendRatingButton = new MetroFramework.Controls.MetroButton();
            this.RatingBox = new MetroFramework.Controls.MetroComboBox();
            this.FormLabel = new System.Windows.Forms.Label();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.StyleLabel = new System.Windows.Forms.Label();
            this.FinishingLabel = new System.Windows.Forms.Label();
            this.TakeOfLabel = new System.Windows.Forms.Label();
            this.CurrentDiverGenderLabel = new System.Windows.Forms.Label();
            this.CurrentDiverNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(8, 115);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(62, 19);
            this.metroLabel15.TabIndex = 10;
            this.metroLabel15.Text = "Finishing:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(8, 25);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(39, 19);
            this.metroLabel11.TabIndex = 11;
            this.metroLabel11.Text = "Style:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(8, 55);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(64, 19);
            this.metroLabel12.TabIndex = 12;
            this.metroLabel12.Text = "Difficulity:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(8, 85);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(44, 19);
            this.metroLabel13.TabIndex = 13;
            this.metroLabel13.Text = "Form:";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(8, 145);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(61, 19);
            this.metroLabel14.TabIndex = 14;
            this.metroLabel14.Text = "Take Off:";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel17.Location = new System.Drawing.Point(23, 63);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(48, 19);
            this.metroLabel17.TabIndex = 16;
            this.metroLabel17.Text = "Name:";
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroLabel18.Location = new System.Drawing.Point(205, 63);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(56, 19);
            this.metroLabel18.TabIndex = 17;
            this.metroLabel18.Text = "Gender:";
            // 
            // SendRatingButton
            // 
            this.SendRatingButton.Location = new System.Drawing.Point(6, 73);
            this.SendRatingButton.Name = "SendRatingButton";
            this.SendRatingButton.Size = new System.Drawing.Size(152, 91);
            this.SendRatingButton.TabIndex = 19;
            this.SendRatingButton.Text = "Send Rating";
            this.SendRatingButton.UseSelectable = true;
            this.SendRatingButton.Click += new System.EventHandler(this.SendRatingButton_Click);
            // 
            // RatingBox
            // 
            this.RatingBox.DisplayMember = "0";
            this.RatingBox.FormattingEnabled = true;
            this.RatingBox.ItemHeight = 23;
            this.RatingBox.Items.AddRange(new object[] {
            "0",
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0",
            "3.5",
            "4.0",
            "4.5",
            "5.0",
            "5.5",
            "6.0",
            "6.5",
            "7.0",
            "7.5",
            "8.0",
            "8.5",
            "9.0",
            "9.5",
            "10.0"});
            this.RatingBox.Location = new System.Drawing.Point(6, 28);
            this.RatingBox.Name = "RatingBox";
            this.RatingBox.Size = new System.Drawing.Size(152, 29);
            this.RatingBox.TabIndex = 20;
            this.RatingBox.UseSelectable = true;
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormLabel.Location = new System.Drawing.Point(81, 88);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(42, 13);
            this.FormLabel.TabIndex = 32;
            this.FormLabel.Text = "<Form>";
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DifficultyLabel.Location = new System.Drawing.Point(81, 58);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(59, 13);
            this.DifficultyLabel.TabIndex = 31;
            this.DifficultyLabel.Text = "<Difficulty>";
            // 
            // StyleLabel
            // 
            this.StyleLabel.AutoSize = true;
            this.StyleLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StyleLabel.Location = new System.Drawing.Point(81, 28);
            this.StyleLabel.Name = "StyleLabel";
            this.StyleLabel.Size = new System.Drawing.Size(42, 13);
            this.StyleLabel.TabIndex = 30;
            this.StyleLabel.Text = "<Style>";
            // 
            // FinishingLabel
            // 
            this.FinishingLabel.AutoSize = true;
            this.FinishingLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FinishingLabel.Location = new System.Drawing.Point(81, 118);
            this.FinishingLabel.Name = "FinishingLabel";
            this.FinishingLabel.Size = new System.Drawing.Size(60, 13);
            this.FinishingLabel.TabIndex = 34;
            this.FinishingLabel.Text = "<Finishing>";
            // 
            // TakeOfLabel
            // 
            this.TakeOfLabel.AutoSize = true;
            this.TakeOfLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TakeOfLabel.Location = new System.Drawing.Point(81, 148);
            this.TakeOfLabel.Name = "TakeOfLabel";
            this.TakeOfLabel.Size = new System.Drawing.Size(61, 13);
            this.TakeOfLabel.TabIndex = 33;
            this.TakeOfLabel.Text = "<Take Off>";
            // 
            // CurrentDiverGenderLabel
            // 
            this.CurrentDiverGenderLabel.AutoSize = true;
            this.CurrentDiverGenderLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CurrentDiverGenderLabel.Location = new System.Drawing.Point(265, 66);
            this.CurrentDiverGenderLabel.Name = "CurrentDiverGenderLabel";
            this.CurrentDiverGenderLabel.Size = new System.Drawing.Size(54, 13);
            this.CurrentDiverGenderLabel.TabIndex = 36;
            this.CurrentDiverGenderLabel.Text = "<Gender>";
            // 
            // CurrentDiverNameLabel
            // 
            this.CurrentDiverNameLabel.AutoSize = true;
            this.CurrentDiverNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CurrentDiverNameLabel.Location = new System.Drawing.Point(83, 66);
            this.CurrentDiverNameLabel.Name = "CurrentDiverNameLabel";
            this.CurrentDiverNameLabel.Size = new System.Drawing.Size(47, 13);
            this.CurrentDiverNameLabel.TabIndex = 35;
            this.CurrentDiverNameLabel.Text = "<Name>";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel11);
            this.groupBox1.Controls.Add(this.metroLabel15);
            this.groupBox1.Controls.Add(this.metroLabel12);
            this.groupBox1.Controls.Add(this.FinishingLabel);
            this.groupBox1.Controls.Add(this.metroLabel13);
            this.groupBox1.Controls.Add(this.TakeOfLabel);
            this.groupBox1.Controls.Add(this.metroLabel14);
            this.groupBox1.Controls.Add(this.FormLabel);
            this.groupBox1.Controls.Add(this.StyleLabel);
            this.groupBox1.Controls.Add(this.DifficultyLabel);
            this.groupBox1.Location = new System.Drawing.Point(23, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 181);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jump Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RatingBox);
            this.groupBox2.Controls.Add(this.SendRatingButton);
            this.groupBox2.Location = new System.Drawing.Point(205, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 181);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Overall Grade";
            // 
            // judge_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 305);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CurrentDiverGenderLabel);
            this.Controls.Add(this.CurrentDiverNameLabel);
            this.Controls.Add(this.metroLabel18);
            this.Controls.Add(this.metroLabel17);
            this.Name = "judge_form";
            this.Resizable = false;
            this.Text = "Welcome, ";
            this.Load += new System.EventHandler(this.judge_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroComboBox RatingBox;
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.Label StyleLabel;
        private System.Windows.Forms.Label FinishingLabel;
        private System.Windows.Forms.Label TakeOfLabel;
        private System.Windows.Forms.Label CurrentDiverGenderLabel;
        private System.Windows.Forms.Label CurrentDiverNameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public MetroFramework.Controls.MetroButton SendRatingButton;
    }
}