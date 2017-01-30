namespace Member_base
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
            this.authenticator = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.auth_button = new System.Windows.Forms.Button();
            this.help_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authenticator
            // 
            this.authenticator.Location = new System.Drawing.Point(12, 25);
            this.authenticator.MaxLength = 6;
            this.authenticator.Name = "authenticator";
            this.authenticator.Size = new System.Drawing.Size(171, 20);
            this.authenticator.TabIndex = 0;
            this.authenticator.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter access code:";
            // 
            // auth_button
            // 
            this.auth_button.Location = new System.Drawing.Point(12, 52);
            this.auth_button.Name = "auth_button";
            this.auth_button.Size = new System.Drawing.Size(85, 51);
            this.auth_button.TabIndex = 2;
            this.auth_button.Text = "Login";
            this.auth_button.UseVisualStyleBackColor = true;
            this.auth_button.Click += new System.EventHandler(this.auth_button_Click);
            // 
            // help_button
            // 
            this.help_button.Location = new System.Drawing.Point(98, 52);
            this.help_button.Name = "help_button";
            this.help_button.Size = new System.Drawing.Size(85, 51);
            this.help_button.TabIndex = 3;
            this.help_button.Text = "Help?";
            this.help_button.UseVisualStyleBackColor = true;
            // 
            // auth_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 114);
            this.Controls.Add(this.help_button);
            this.Controls.Add(this.auth_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authenticator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "auth_form";
            this.Text = "Authenticate";
            this.Load += new System.EventHandler(this.auth_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox authenticator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button auth_button;
        private System.Windows.Forms.Button help_button;
    }
}