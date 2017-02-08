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
            this.ExitButton = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.authBox = new System.Windows.Forms.TextBox();
            this.DiverButton = new MetroFramework.Controls.MetroCheckBox();
            this.JudgeButton = new MetroFramework.Controls.MetroCheckBox();
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
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(152, 169);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(126, 46);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseSelectable = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButn_Click);
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
            // authBox
            // 
            this.authBox.Location = new System.Drawing.Point(23, 143);
            this.authBox.Name = "authBox";
            this.authBox.Size = new System.Drawing.Size(255, 20);
            this.authBox.TabIndex = 9;
            this.authBox.UseSystemPasswordChar = true;
            this.authBox.TextChanged += new System.EventHandler(this.authBox_TextChanged);
            // 
            // DiverButton
            // 
            this.DiverButton.AutoSize = true;
            this.DiverButton.Location = new System.Drawing.Point(23, 122);
            this.DiverButton.Name = "DiverButton";
            this.DiverButton.Size = new System.Drawing.Size(50, 15);
            this.DiverButton.TabIndex = 10;
            this.DiverButton.Text = "Diver";
            this.DiverButton.UseSelectable = true;
            this.DiverButton.CheckedChanged += new System.EventHandler(this.DiverButton_CheckedChanged);
            // 
            // JudgeButton
            // 
            this.JudgeButton.AutoSize = true;
            this.JudgeButton.Location = new System.Drawing.Point(152, 122);
            this.JudgeButton.Name = "JudgeButton";
            this.JudgeButton.Size = new System.Drawing.Size(54, 15);
            this.JudgeButton.TabIndex = 11;
            this.JudgeButton.Text = "Judge";
            this.JudgeButton.UseSelectable = true;
            // 
            // main_auth_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(304, 241);
            this.Controls.Add(this.JudgeButton);
            this.Controls.Add(this.DiverButton);
            this.Controls.Add(this.authBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
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
        public MetroFramework.Controls.MetroButton ExitButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox authBox;
        public MetroFramework.Controls.MetroCheckBox DiverButton;
        public MetroFramework.Controls.MetroCheckBox JudgeButton;
    }
}