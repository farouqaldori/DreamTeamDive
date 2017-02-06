namespace Diver_Contest
{
    partial class main_auth_form
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
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.ExitButn = new MetroFramework.Controls.MetroButton();
            this.authBOX = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.JudgeRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.DiverRadioButton = new MetroFramework.Controls.MetroRadioButton();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(23, 169);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(126, 46);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseSelectable = true;
            this.LoginButton.Click += new System.EventHandler(this.Login_Click);
            // 
            // ExitButn
            // 
            this.ExitButn.Location = new System.Drawing.Point(152, 169);
            this.ExitButn.Name = "ExitButn";
            this.ExitButn.Size = new System.Drawing.Size(126, 46);
            this.ExitButn.TabIndex = 4;
            this.ExitButn.Text = "Exit";
            this.ExitButn.UseSelectable = true;
            this.ExitButn.Click += new System.EventHandler(this.ExitButn_Click);
            // 
            // authBOX
            // 
            // 
            // 
            // 
            this.authBOX.CustomButton.Image = null;
            this.authBOX.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.authBOX.CustomButton.Name = "";
            this.authBOX.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.authBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.authBOX.CustomButton.TabIndex = 1;
            this.authBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.authBOX.CustomButton.UseSelectable = true;
            this.authBOX.CustomButton.Visible = false;
            this.authBOX.Lines = new string[0];
            this.authBOX.Location = new System.Drawing.Point(23, 140);
            this.authBOX.MaxLength = 32767;
            this.authBOX.Name = "authBOX";
            this.authBOX.PasswordChar = '\0';
            this.authBOX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.authBOX.SelectedText = "";
            this.authBOX.SelectionLength = 0;
            this.authBOX.SelectionStart = 0;
            this.authBOX.ShortcutsEnabled = true;
            this.authBOX.Size = new System.Drawing.Size(255, 23);
            this.authBOX.TabIndex = 5;
            this.authBOX.UseSelectable = true;
            this.authBOX.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.authBOX.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.authBOX.Click += new System.EventHandler(this.TextBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Identify yourself with authentication code";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // JudgeRadioButton
            // 
            this.JudgeRadioButton.AutoSize = true;
            this.JudgeRadioButton.Location = new System.Drawing.Point(152, 119);
            this.JudgeRadioButton.Name = "JudgeRadioButton";
            this.JudgeRadioButton.Size = new System.Drawing.Size(54, 15);
            this.JudgeRadioButton.TabIndex = 7;
            this.JudgeRadioButton.Text = "Judge";
            this.JudgeRadioButton.UseSelectable = true;
            // 
            // DiverRadioButton
            // 
            this.DiverRadioButton.AutoSize = true;
            this.DiverRadioButton.Location = new System.Drawing.Point(23, 119);
            this.DiverRadioButton.Name = "DiverRadioButton";
            this.DiverRadioButton.Size = new System.Drawing.Size(50, 15);
            this.DiverRadioButton.TabIndex = 8;
            this.DiverRadioButton.Text = "Diver";
            this.DiverRadioButton.UseSelectable = true;
            // 
            // main_auth_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(304, 241);
            this.Controls.Add(this.DiverRadioButton);
            this.Controls.Add(this.JudgeRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authBOX);
            this.Controls.Add(this.ExitButn);
            this.Controls.Add(this.LoginButton);
            this.Name = "main_auth_form";
            this.Text = "Welcome to DT Dive";
            this.Load += new System.EventHandler(this.main_auth_form_Load);
            this.MouseHover += new System.EventHandler(this.main_auth_form_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroButton LoginButton;
        public MetroFramework.Controls.MetroButton ExitButn;
        private System.Windows.Forms.Label label1;
        public MetroFramework.Controls.MetroTextBox authBOX;
        public MetroFramework.Controls.MetroRadioButton JudgeRadioButton;
        public MetroFramework.Controls.MetroRadioButton DiverRadioButton;
    }
}