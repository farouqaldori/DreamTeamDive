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
            this.Light = new MetroFramework.Controls.MetroButton();
            this.Dark = new MetroFramework.Controls.MetroButton();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.Apply = new MetroFramework.Controls.MetroButton();
            this.showchld = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.contest_tab = new MetroFramework.Controls.MetroTabPage();
            this.ResetButton = new MetroFramework.Controls.MetroButton();
            this.SubmitButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroRadioButton7 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton6 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton5 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton4 = new MetroFramework.Controls.MetroRadioButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.judge_tab = new MetroFramework.Controls.MetroTabPage();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.Hopper_tab = new MetroFramework.Controls.MetroTabPage();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.contest_tab.SuspendLayout();
            this.judge_tab.SuspendLayout();
            this.Hopper_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            // 
            // Light
            // 
            this.Light.Location = new System.Drawing.Point(430, 24);
            this.Light.Name = "Light";
            this.Light.Size = new System.Drawing.Size(45, 29);
            this.Light.TabIndex = 0;
            this.Light.Text = "Light";
            this.Light.UseSelectable = true;
            this.Light.Click += new System.EventHandler(this.Light_Click);
            // 
            // Dark
            // 
            this.Dark.Location = new System.Drawing.Point(295, 24);
            this.Dark.Name = "Dark";
            this.Dark.Size = new System.Drawing.Size(57, 29);
            this.Dark.TabIndex = 1;
            this.Dark.Text = "Dark";
            this.Dark.UseSelectable = true;
            this.Dark.Click += new System.EventHandler(this.Dark_Click);
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.metroComboBox1.Location = new System.Drawing.Point(168, 24);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.UseSelectable = true;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(98, 24);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(64, 29);
            this.Apply.TabIndex = 3;
            this.Apply.Text = "Apply";
            this.Apply.UseSelectable = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // showchld
            // 
            this.showchld.Location = new System.Drawing.Point(358, 24);
            this.showchld.Name = "showchld";
            this.showchld.Size = new System.Drawing.Size(66, 29);
            this.showchld.TabIndex = 4;
            this.showchld.Text = "showchld";
            this.showchld.UseSelectable = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.contest_tab);
            this.metroTabControl1.Controls.Add(this.judge_tab);
            this.metroTabControl1.Controls.Add(this.Hopper_tab);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(461, 266);
            this.metroTabControl1.TabIndex = 5;
            this.metroTabControl1.UseSelectable = true;
            // 
            // contest_tab
            // 
            this.contest_tab.Controls.Add(this.ResetButton);
            this.contest_tab.Controls.Add(this.SubmitButton);
            this.contest_tab.Controls.Add(this.metroLabel3);
            this.contest_tab.Controls.Add(this.metroDateTime1);
            this.contest_tab.Controls.Add(this.metroRadioButton7);
            this.contest_tab.Controls.Add(this.metroRadioButton6);
            this.contest_tab.Controls.Add(this.metroRadioButton5);
            this.contest_tab.Controls.Add(this.metroRadioButton4);
            this.contest_tab.Controls.Add(this.metroTextBox1);
            this.contest_tab.Controls.Add(this.metroLabel2);
            this.contest_tab.Controls.Add(this.metroLabel1);
            this.contest_tab.HorizontalScrollbarBarColor = true;
            this.contest_tab.HorizontalScrollbarHighlightOnWheel = false;
            this.contest_tab.HorizontalScrollbarSize = 10;
            this.contest_tab.Location = new System.Drawing.Point(4, 38);
            this.contest_tab.Name = "contest_tab";
            this.contest_tab.Size = new System.Drawing.Size(453, 224);
            this.contest_tab.TabIndex = 0;
            this.contest_tab.Text = "Contest";
            this.contest_tab.VerticalScrollbarBarColor = true;
            this.contest_tab.VerticalScrollbarHighlightOnWheel = false;
            this.contest_tab.VerticalScrollbarSize = 10;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(169, 183);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(135, 38);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseSelectable = true;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(0, 183);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(135, 38);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(0, 117);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Date:";
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(104, 113);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(4, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 10;
            this.metroDateTime1.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // metroRadioButton7
            // 
            this.metroRadioButton7.AutoSize = true;
            this.metroRadioButton7.Location = new System.Drawing.Point(125, 79);
            this.metroRadioButton7.Name = "metroRadioButton7";
            this.metroRadioButton7.Size = new System.Drawing.Size(29, 15);
            this.metroRadioButton7.TabIndex = 9;
            this.metroRadioButton7.Text = "3";
            this.metroRadioButton7.UseSelectable = true;
            // 
            // metroRadioButton6
            // 
            this.metroRadioButton6.AutoSize = true;
            this.metroRadioButton6.Location = new System.Drawing.Point(275, 79);
            this.metroRadioButton6.Name = "metroRadioButton6";
            this.metroRadioButton6.Size = new System.Drawing.Size(29, 15);
            this.metroRadioButton6.TabIndex = 8;
            this.metroRadioButton6.Text = "9";
            this.metroRadioButton6.UseSelectable = true;
            // 
            // metroRadioButton5
            // 
            this.metroRadioButton5.AutoSize = true;
            this.metroRadioButton5.Location = new System.Drawing.Point(225, 79);
            this.metroRadioButton5.Name = "metroRadioButton5";
            this.metroRadioButton5.Size = new System.Drawing.Size(29, 15);
            this.metroRadioButton5.TabIndex = 7;
            this.metroRadioButton5.Text = "7";
            this.metroRadioButton5.UseSelectable = true;
            // 
            // metroRadioButton4
            // 
            this.metroRadioButton4.AutoSize = true;
            this.metroRadioButton4.Location = new System.Drawing.Point(175, 79);
            this.metroRadioButton4.Name = "metroRadioButton4";
            this.metroRadioButton4.Size = new System.Drawing.Size(29, 15);
            this.metroRadioButton4.TabIndex = 6;
            this.metroRadioButton4.Text = "5";
            this.metroRadioButton4.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "<Name and Surname>"};
            this.metroTextBox1.Location = new System.Drawing.Point(137, 33);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(167, 23);
            this.metroTextBox1.TabIndex = 5;
            this.metroTextBox1.Text = "<Name and Surname>";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(0, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(119, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Amount of Judges:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(0, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(135, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Type Of Competition:";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // judge_tab
            // 
            this.judge_tab.Controls.Add(this.metroButton3);
            this.judge_tab.Controls.Add(this.metroButton4);
            this.judge_tab.Controls.Add(this.metroLabel8);
            this.judge_tab.Controls.Add(this.metroLabel7);
            this.judge_tab.HorizontalScrollbarBarColor = true;
            this.judge_tab.HorizontalScrollbarHighlightOnWheel = false;
            this.judge_tab.HorizontalScrollbarSize = 10;
            this.judge_tab.Location = new System.Drawing.Point(4, 38);
            this.judge_tab.Name = "judge_tab";
            this.judge_tab.Size = new System.Drawing.Size(453, 224);
            this.judge_tab.TabIndex = 1;
            this.judge_tab.Text = "Judge";
            this.judge_tab.VerticalScrollbarBarColor = true;
            this.judge_tab.VerticalScrollbarHighlightOnWheel = false;
            this.judge_tab.VerticalScrollbarSize = 10;
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(169, 183);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(135, 38);
            this.metroButton3.TabIndex = 15;
            this.metroButton3.Text = "Reset";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(0, 183);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(135, 38);
            this.metroButton4.TabIndex = 14;
            this.metroButton4.Text = "Submit";
            this.metroButton4.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(0, 75);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(85, 19);
            this.metroLabel8.TabIndex = 3;
            this.metroLabel8.Text = "Competition:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(0, 33);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(48, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Name:";
            // 
            // Hopper_tab
            // 
            this.Hopper_tab.Controls.Add(this.metroButton5);
            this.Hopper_tab.Controls.Add(this.metroButton6);
            this.Hopper_tab.Controls.Add(this.metroRadioButton3);
            this.Hopper_tab.Controls.Add(this.metroRadioButton2);
            this.Hopper_tab.Controls.Add(this.metroRadioButton1);
            this.Hopper_tab.Controls.Add(this.metroTextBox2);
            this.Hopper_tab.Controls.Add(this.metroTextBox4);
            this.Hopper_tab.Controls.Add(this.metroLabel4);
            this.Hopper_tab.Controls.Add(this.metroLabel5);
            this.Hopper_tab.Controls.Add(this.metroLabel6);
            this.Hopper_tab.HorizontalScrollbarBarColor = true;
            this.Hopper_tab.HorizontalScrollbarHighlightOnWheel = false;
            this.Hopper_tab.HorizontalScrollbarSize = 10;
            this.Hopper_tab.Location = new System.Drawing.Point(4, 38);
            this.Hopper_tab.Name = "Hopper_tab";
            this.Hopper_tab.Size = new System.Drawing.Size(453, 224);
            this.Hopper_tab.TabIndex = 2;
            this.Hopper_tab.Text = "Hopper";
            this.Hopper_tab.VerticalScrollbarBarColor = true;
            this.Hopper_tab.VerticalScrollbarHighlightOnWheel = false;
            this.Hopper_tab.VerticalScrollbarSize = 10;
            this.Hopper_tab.Click += new System.EventHandler(this.Hopper_tab_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(169, 183);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(135, 38);
            this.metroButton5.TabIndex = 17;
            this.metroButton5.Text = "Reset";
            this.metroButton5.UseSelectable = true;
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(0, 183);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(135, 38);
            this.metroButton6.TabIndex = 16;
            this.metroButton6.Text = "Submit";
            this.metroButton6.UseSelectable = true;
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Location = new System.Drawing.Point(187, 81);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(53, 15);
            this.metroRadioButton3.TabIndex = 15;
            this.metroRadioButton3.Text = "Other";
            this.metroRadioButton3.UseSelectable = true;
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(120, 81);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(61, 15);
            this.metroRadioButton2.TabIndex = 14;
            this.metroRadioButton2.Text = "Female";
            this.metroRadioButton2.UseSelectable = true;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(65, 80);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(49, 15);
            this.metroRadioButton1.TabIndex = 13;
            this.metroRadioButton1.Text = "Male";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[] {
        "<Country>"};
            this.metroTextBox2.Location = new System.Drawing.Point(65, 121);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(175, 23);
            this.metroTextBox2.TabIndex = 12;
            this.metroTextBox2.Text = "<Country>";
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(153, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[] {
        "<Name and Surname>"};
            this.metroTextBox4.Location = new System.Drawing.Point(65, 33);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(175, 23);
            this.metroTextBox4.TabIndex = 11;
            this.metroTextBox4.Text = "<Name and Surname>";
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(0, 121);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Country:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(0, 77);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Gender:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(0, 33);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Name: ";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 352);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.showchld);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.Dark);
            this.Controls.Add(this.Light);
            this.Name = "Main";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.contest_tab.ResumeLayout(false);
            this.contest_tab.PerformLayout();
            this.judge_tab.ResumeLayout(false);
            this.judge_tab.PerformLayout();
            this.Hopper_tab.ResumeLayout(false);
            this.Hopper_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroButton Dark;
        private MetroFramework.Controls.MetroButton Light;
        private MetroFramework.Controls.MetroButton Apply;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroButton showchld;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage contest_tab;
        private MetroFramework.Controls.MetroTabPage judge_tab;
        private MetroFramework.Controls.MetroTabPage Hopper_tab;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton7;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton6;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton5;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton4;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroButton ResetButton;
        private MetroFramework.Controls.MetroButton SubmitButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton6;
    }
}

