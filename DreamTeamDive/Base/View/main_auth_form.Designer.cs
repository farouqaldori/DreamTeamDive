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
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(92, 87);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(128, 65);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Log In";
            this.LoginButton.UseSelectable = true;
            this.LoginButton.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ExitButn
            // 
            this.ExitButn.Location = new System.Drawing.Point(226, 87);
            this.ExitButn.Name = "ExitButn";
            this.ExitButn.Size = new System.Drawing.Size(121, 65);
            this.ExitButn.TabIndex = 4;
            this.ExitButn.Text = "Exit";
            this.ExitButn.UseSelectable = true;
            this.ExitButn.Click += new System.EventHandler(this.ExitButn_Click);
            // 
            // main_auth_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(368, 168);
            this.Controls.Add(this.ExitButn);
            this.Controls.Add(this.LoginButton);
            this.Name = "main_auth_form";
            this.Text = "Welcome to DreamTeam Dive";
            this.Load += new System.EventHandler(this.main_auth_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroButton LoginButton;
        public MetroFramework.Controls.MetroButton ExitButn;
    }
}