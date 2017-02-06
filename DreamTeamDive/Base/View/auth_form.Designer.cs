namespace Diver_Contest
{
    partial class auth_form
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
            this.authBOX = new MetroFramework.Controls.MetroTextBox();
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.HelpButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // authBOX
            // 
            // 
            // 
            // 
            this.authBOX.CustomButton.Image = null;
            this.authBOX.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.authBOX.CustomButton.Name = "";
            this.authBOX.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.authBOX.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.authBOX.CustomButton.TabIndex = 1;
            this.authBOX.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.authBOX.CustomButton.UseSelectable = true;
            this.authBOX.CustomButton.Visible = false;
            this.authBOX.Lines = new string[] {
        "<Code>"};
            this.authBOX.Location = new System.Drawing.Point(23, 88);
            this.authBOX.MaxLength = 32767;
            this.authBOX.Name = "authBOX";
            this.authBOX.PasswordChar = '\0';
            this.authBOX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.authBOX.SelectedText = "";
            this.authBOX.SelectionLength = 0;
            this.authBOX.SelectionStart = 0;
            this.authBOX.ShortcutsEnabled = true;
            this.authBOX.Size = new System.Drawing.Size(253, 23);
            this.authBOX.TabIndex = 0;
            this.authBOX.Text = "<Code>";
            this.authBOX.UseSelectable = true;
            this.authBOX.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.authBOX.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.authBOX.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(23, 138);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(115, 47);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseSelectable = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(161, 138);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(115, 47);
            this.HelpButton.TabIndex = 2;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseSelectable = true;
            // 
            // auth_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 231);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.authBOX);
            this.Name = "auth_form";
            this.Text = "Authenticate";
            this.Load += new System.EventHandler(this.auth_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox authBOX;
        private MetroFramework.Controls.MetroButton LoginButton;
        private MetroFramework.Controls.MetroButton HelpButton;
    }
}