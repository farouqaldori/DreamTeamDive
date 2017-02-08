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
            this.diver_radio_button = new MetroFramework.Controls.MetroRadioButton();
            this.judge_radio_button = new MetroFramework.Controls.MetroRadioButton();
            this.show_pass_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(23, 169);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(126, 46);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseSelectable = true;
            this.LoginButton.Click += new System.EventHandler(this.Login_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(152, 169);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(126, 46);
            this.ExitButton.TabIndex = 5;
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
            this.authBox.Size = new System.Drawing.Size(220, 20);
            this.authBox.TabIndex = 3;
            this.authBox.UseSystemPasswordChar = true;
            this.authBox.TextChanged += new System.EventHandler(this.authBox_TextChanged);
            // 
            // diver_radio_button
            // 
            this.diver_radio_button.AutoSize = true;
            this.diver_radio_button.Checked = true;
            this.diver_radio_button.Location = new System.Drawing.Point(23, 122);
            this.diver_radio_button.Name = "diver_radio_button";
            this.diver_radio_button.Size = new System.Drawing.Size(50, 15);
            this.diver_radio_button.TabIndex = 99;
            this.diver_radio_button.TabStop = true;
            this.diver_radio_button.Text = "Diver";
            this.diver_radio_button.UseSelectable = true;
            // 
            // judge_radio_button
            // 
            this.judge_radio_button.AutoSize = true;
            this.judge_radio_button.Location = new System.Drawing.Point(152, 122);
            this.judge_radio_button.Name = "judge_radio_button";
            this.judge_radio_button.Size = new System.Drawing.Size(54, 15);
            this.judge_radio_button.TabIndex = 99;
            this.judge_radio_button.Text = "Judge";
            this.judge_radio_button.UseSelectable = true;
            // 
            // show_pass_button
            // 
            this.show_pass_button.Image = global::Base.Properties.Resources.eye_icon1;
            this.show_pass_button.Location = new System.Drawing.Point(249, 143);
            this.show_pass_button.Name = "show_pass_button";
            this.show_pass_button.Size = new System.Drawing.Size(29, 20);
            this.show_pass_button.TabIndex = 100;
            this.show_pass_button.UseVisualStyleBackColor = true;
            this.show_pass_button.Click += new System.EventHandler(this.show_pass_button_Click);
            // 
            // main_auth_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(304, 241);
            this.Controls.Add(this.show_pass_button);
            this.Controls.Add(this.judge_radio_button);
            this.Controls.Add(this.diver_radio_button);
            this.Controls.Add(this.authBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginButton);
            this.Name = "main_auth_form";
            this.Text = "Welcome to DT Dive";
            this.MouseHover += new System.EventHandler(this.main_auth_form_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroButton LoginButton;
        public MetroFramework.Controls.MetroButton ExitButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox authBox;
        public MetroFramework.Controls.MetroRadioButton diver_radio_button;
        public MetroFramework.Controls.MetroRadioButton judge_radio_button;
        private System.Windows.Forms.Button show_pass_button;
    }
}