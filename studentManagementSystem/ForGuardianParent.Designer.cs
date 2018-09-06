namespace studentManagementSystem
{
    partial class ForGuardianParent
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
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.lbnBack = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.metroTextBox17 = new MetroFramework.Controls.MetroTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.metroTextBox16 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox15 = new MetroFramework.Controls.MetroTextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.metroTextBox14 = new MetroFramework.Controls.MetroTextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.metroTextBox13 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox12 = new MetroFramework.Controls.MetroTextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.metroTextBox11 = new MetroFramework.Controls.MetroTextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.metroTextBox10 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox9 = new MetroFramework.Controls.MetroTextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.metroTextBox8 = new MetroFramework.Controls.MetroTextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.CheckBox2 = new System.Windows.Forms.CheckBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.opfl = new System.Windows.Forms.OpenFileDialog();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.lbnBack);
            this.GroupBox2.Controls.Add(this.pictureBox1);
            this.GroupBox2.Controls.Add(this.groupBox1);
            this.GroupBox2.Controls.Add(this.GroupBox4);
            this.GroupBox2.Controls.Add(this.GroupBox3);
            this.GroupBox2.Controls.Add(this.btnSaveAll);
            this.GroupBox2.Location = new System.Drawing.Point(9, 51);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(1027, 592);
            this.GroupBox2.TabIndex = 3;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // lbnBack
            // 
            this.lbnBack.AutoSize = true;
            this.lbnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnBack.ForeColor = System.Drawing.Color.Blue;
            this.lbnBack.Location = new System.Drawing.Point(936, 537);
            this.lbnBack.Name = "lbnBack";
            this.lbnBack.Size = new System.Drawing.Size(45, 20);
            this.lbnBack.TabIndex = 27;
            this.lbnBack.Text = "Back";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::studentManagementSystem.Properties.Resources.if_arrow_back_backwards_repeat_previous_blue_1872775;
            this.pictureBox1.Location = new System.Drawing.Point(894, 500);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroComboBox1);
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(592, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 153);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miscellaneous Details";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "Birth Certifiate",
            "National Passport"});
            this.metroComboBox1.Location = new System.Drawing.Point(170, 47);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(206, 29);
            this.metroComboBox1.TabIndex = 28;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged_1);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Blue;
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Location = new System.Drawing.Point(20, 96);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(124, 32);
            this.btnUpload.TabIndex = 26;
            this.btnUpload.Text = "Select From Gallery";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Means of Identification? ";
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.metroTextBox17);
            this.GroupBox4.Controls.Add(this.label21);
            this.GroupBox4.Controls.Add(this.metroTextBox16);
            this.GroupBox4.Controls.Add(this.metroTextBox15);
            this.GroupBox4.Controls.Add(this.Label20);
            this.GroupBox4.Controls.Add(this.Label19);
            this.GroupBox4.Controls.Add(this.metroTextBox14);
            this.GroupBox4.Controls.Add(this.Label11);
            this.GroupBox4.Location = new System.Drawing.Point(41, 385);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(525, 186);
            this.GroupBox4.TabIndex = 24;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Guardian Information";
            // 
            // metroTextBox17
            // 
            // 
            // 
            // 
            this.metroTextBox17.CustomButton.Image = null;
            this.metroTextBox17.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.metroTextBox17.CustomButton.Name = "";
            this.metroTextBox17.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox17.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox17.CustomButton.TabIndex = 1;
            this.metroTextBox17.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox17.CustomButton.UseSelectable = true;
            this.metroTextBox17.CustomButton.Visible = false;
            this.metroTextBox17.Lines = new string[0];
            this.metroTextBox17.Location = new System.Drawing.Point(137, 152);
            this.metroTextBox17.MaxLength = 32767;
            this.metroTextBox17.Name = "metroTextBox17";
            this.metroTextBox17.PasswordChar = '\0';
            this.metroTextBox17.PromptText = "Enter Occupation...";
            this.metroTextBox17.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox17.SelectedText = "";
            this.metroTextBox17.SelectionLength = 0;
            this.metroTextBox17.SelectionStart = 0;
            this.metroTextBox17.ShortcutsEnabled = true;
            this.metroTextBox17.Size = new System.Drawing.Size(321, 23);
            this.metroTextBox17.TabIndex = 38;
            this.metroTextBox17.UseSelectable = true;
            this.metroTextBox17.WaterMark = "Enter Occupation...";
            this.metroTextBox17.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox17.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 152);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(111, 13);
            this.label21.TabIndex = 37;
            this.label21.Text = "Guardian Occupation:";
            // 
            // metroTextBox16
            // 
            // 
            // 
            // 
            this.metroTextBox16.CustomButton.Image = null;
            this.metroTextBox16.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.metroTextBox16.CustomButton.Name = "";
            this.metroTextBox16.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox16.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox16.CustomButton.TabIndex = 1;
            this.metroTextBox16.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox16.CustomButton.UseSelectable = true;
            this.metroTextBox16.CustomButton.Visible = false;
            this.metroTextBox16.Lines = new string[0];
            this.metroTextBox16.Location = new System.Drawing.Point(137, 108);
            this.metroTextBox16.MaxLength = 32767;
            this.metroTextBox16.Name = "metroTextBox16";
            this.metroTextBox16.PasswordChar = '\0';
            this.metroTextBox16.PromptText = "Enter PhoneNumber...";
            this.metroTextBox16.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox16.SelectedText = "";
            this.metroTextBox16.SelectionLength = 0;
            this.metroTextBox16.SelectionStart = 0;
            this.metroTextBox16.ShortcutsEnabled = true;
            this.metroTextBox16.Size = new System.Drawing.Size(321, 23);
            this.metroTextBox16.TabIndex = 35;
            this.metroTextBox16.UseSelectable = true;
            this.metroTextBox16.WaterMark = "Enter PhoneNumber...";
            this.metroTextBox16.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox16.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox15
            // 
            // 
            // 
            // 
            this.metroTextBox15.CustomButton.Image = null;
            this.metroTextBox15.CustomButton.Location = new System.Drawing.Point(301, 1);
            this.metroTextBox15.CustomButton.Name = "";
            this.metroTextBox15.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox15.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox15.CustomButton.TabIndex = 1;
            this.metroTextBox15.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox15.CustomButton.UseSelectable = true;
            this.metroTextBox15.CustomButton.Visible = false;
            this.metroTextBox15.Lines = new string[0];
            this.metroTextBox15.Location = new System.Drawing.Point(135, 69);
            this.metroTextBox15.MaxLength = 32767;
            this.metroTextBox15.Name = "metroTextBox15";
            this.metroTextBox15.PasswordChar = '\0';
            this.metroTextBox15.PromptText = "Enter RelationShip...";
            this.metroTextBox15.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox15.SelectedText = "";
            this.metroTextBox15.SelectionLength = 0;
            this.metroTextBox15.SelectionStart = 0;
            this.metroTextBox15.ShortcutsEnabled = true;
            this.metroTextBox15.Size = new System.Drawing.Size(323, 23);
            this.metroTextBox15.TabIndex = 33;
            this.metroTextBox15.UseSelectable = true;
            this.metroTextBox15.WaterMark = "Enter RelationShip...";
            this.metroTextBox15.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox15.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(6, 108);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(124, 13);
            this.Label20.TabIndex = 30;
            this.Label20.Text = "Guardian PhoneNumber:";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(6, 69);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(70, 13);
            this.Label19.TabIndex = 29;
            this.Label19.Text = "RelationShip:";
            // 
            // metroTextBox14
            // 
            // 
            // 
            // 
            this.metroTextBox14.CustomButton.Image = null;
            this.metroTextBox14.CustomButton.Location = new System.Drawing.Point(301, 1);
            this.metroTextBox14.CustomButton.Name = "";
            this.metroTextBox14.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox14.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox14.CustomButton.TabIndex = 1;
            this.metroTextBox14.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox14.CustomButton.UseSelectable = true;
            this.metroTextBox14.CustomButton.Visible = false;
            this.metroTextBox14.Lines = new string[0];
            this.metroTextBox14.Location = new System.Drawing.Point(135, 28);
            this.metroTextBox14.MaxLength = 32767;
            this.metroTextBox14.Name = "metroTextBox14";
            this.metroTextBox14.PasswordChar = '\0';
            this.metroTextBox14.PromptText = "Enter Name...";
            this.metroTextBox14.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox14.SelectedText = "";
            this.metroTextBox14.SelectionLength = 0;
            this.metroTextBox14.SelectionStart = 0;
            this.metroTextBox14.ShortcutsEnabled = true;
            this.metroTextBox14.Size = new System.Drawing.Size(323, 23);
            this.metroTextBox14.TabIndex = 28;
            this.metroTextBox14.UseSelectable = true;
            this.metroTextBox14.WaterMark = "Enter Name...";
            this.metroTextBox14.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox14.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(6, 28);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(84, 13);
            this.Label11.TabIndex = 27;
            this.Label11.Text = "Guardian Name:";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.checkBox5);
            this.GroupBox3.Controls.Add(this.checkBox4);
            this.GroupBox3.Controls.Add(this.label22);
            this.GroupBox3.Controls.Add(this.Label18);
            this.GroupBox3.Controls.Add(this.metroTextBox13);
            this.GroupBox3.Controls.Add(this.metroTextBox12);
            this.GroupBox3.Controls.Add(this.Label17);
            this.GroupBox3.Controls.Add(this.metroTextBox11);
            this.GroupBox3.Controls.Add(this.Label16);
            this.GroupBox3.Controls.Add(this.metroTextBox10);
            this.GroupBox3.Controls.Add(this.metroTextBox9);
            this.GroupBox3.Controls.Add(this.Label15);
            this.GroupBox3.Controls.Add(this.Label14);
            this.GroupBox3.Controls.Add(this.metroTextBox8);
            this.GroupBox3.Controls.Add(this.Label13);
            this.GroupBox3.Controls.Add(this.CheckBox3);
            this.GroupBox3.Controls.Add(this.CheckBox2);
            this.GroupBox3.Controls.Add(this.Label12);
            this.GroupBox3.Location = new System.Drawing.Point(41, 19);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(525, 346);
            this.GroupBox3.TabIndex = 23;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Parents Information";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(222, 311);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(40, 17);
            this.checkBox5.TabIndex = 39;
            this.checkBox5.Text = "No";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(135, 310);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(44, 17);
            this.checkBox4.TabIndex = 38;
            this.checkBox4.Text = "Yes";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 311);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 13);
            this.label22.TabIndex = 37;
            this.label22.Text = "Have a Guardian?";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Location = new System.Drawing.Point(21, 270);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(106, 13);
            this.Label18.TabIndex = 36;
            this.Label18.Text = "Mothers Occupation:";
            // 
            // metroTextBox13
            // 
            // 
            // 
            // 
            this.metroTextBox13.CustomButton.Image = null;
            this.metroTextBox13.CustomButton.Location = new System.Drawing.Point(301, 1);
            this.metroTextBox13.CustomButton.Name = "";
            this.metroTextBox13.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox13.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox13.CustomButton.TabIndex = 1;
            this.metroTextBox13.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox13.CustomButton.UseSelectable = true;
            this.metroTextBox13.CustomButton.Visible = false;
            this.metroTextBox13.Lines = new string[0];
            this.metroTextBox13.Location = new System.Drawing.Point(135, 270);
            this.metroTextBox13.MaxLength = 32767;
            this.metroTextBox13.Name = "metroTextBox13";
            this.metroTextBox13.PasswordChar = '\0';
            this.metroTextBox13.PromptText = "Enter Occupation...";
            this.metroTextBox13.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox13.SelectedText = "";
            this.metroTextBox13.SelectionLength = 0;
            this.metroTextBox13.SelectionStart = 0;
            this.metroTextBox13.ShortcutsEnabled = true;
            this.metroTextBox13.Size = new System.Drawing.Size(323, 23);
            this.metroTextBox13.TabIndex = 35;
            this.metroTextBox13.UseSelectable = true;
            this.metroTextBox13.WaterMark = "Enter Occupation...";
            this.metroTextBox13.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox13.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox12
            // 
            // 
            // 
            // 
            this.metroTextBox12.CustomButton.Image = null;
            this.metroTextBox12.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.metroTextBox12.CustomButton.Name = "";
            this.metroTextBox12.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox12.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox12.CustomButton.TabIndex = 1;
            this.metroTextBox12.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox12.CustomButton.UseSelectable = true;
            this.metroTextBox12.CustomButton.Visible = false;
            this.metroTextBox12.Lines = new string[0];
            this.metroTextBox12.Location = new System.Drawing.Point(137, 218);
            this.metroTextBox12.MaxLength = 32767;
            this.metroTextBox12.Name = "metroTextBox12";
            this.metroTextBox12.PasswordChar = '\0';
            this.metroTextBox12.PromptText = "Enter PhoneNumber...";
            this.metroTextBox12.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox12.SelectedText = "";
            this.metroTextBox12.SelectionLength = 0;
            this.metroTextBox12.SelectionStart = 0;
            this.metroTextBox12.ShortcutsEnabled = true;
            this.metroTextBox12.Size = new System.Drawing.Size(321, 23);
            this.metroTextBox12.TabIndex = 34;
            this.metroTextBox12.UseSelectable = true;
            this.metroTextBox12.WaterMark = "Enter PhoneNumber...";
            this.metroTextBox12.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox12.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(21, 218);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(119, 13);
            this.Label17.TabIndex = 33;
            this.Label17.Text = "Mothers PhoneNumber:";
            // 
            // metroTextBox11
            // 
            // 
            // 
            // 
            this.metroTextBox11.CustomButton.Image = null;
            this.metroTextBox11.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.metroTextBox11.CustomButton.Name = "";
            this.metroTextBox11.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox11.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox11.CustomButton.TabIndex = 1;
            this.metroTextBox11.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox11.CustomButton.UseSelectable = true;
            this.metroTextBox11.CustomButton.Visible = false;
            this.metroTextBox11.Lines = new string[0];
            this.metroTextBox11.Location = new System.Drawing.Point(137, 177);
            this.metroTextBox11.MaxLength = 32767;
            this.metroTextBox11.Name = "metroTextBox11";
            this.metroTextBox11.PasswordChar = '\0';
            this.metroTextBox11.PromptText = "Enter Name...";
            this.metroTextBox11.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox11.SelectedText = "";
            this.metroTextBox11.SelectionLength = 0;
            this.metroTextBox11.SelectionStart = 0;
            this.metroTextBox11.ShortcutsEnabled = true;
            this.metroTextBox11.Size = new System.Drawing.Size(321, 23);
            this.metroTextBox11.TabIndex = 32;
            this.metroTextBox11.UseSelectable = true;
            this.metroTextBox11.WaterMark = "Enter Name...";
            this.metroTextBox11.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox11.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(21, 177);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(79, 13);
            this.Label16.TabIndex = 31;
            this.Label16.Text = "Mothers Name:";
            // 
            // metroTextBox10
            // 
            // 
            // 
            // 
            this.metroTextBox10.CustomButton.Image = null;
            this.metroTextBox10.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.metroTextBox10.CustomButton.Name = "";
            this.metroTextBox10.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox10.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox10.CustomButton.TabIndex = 1;
            this.metroTextBox10.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox10.CustomButton.UseSelectable = true;
            this.metroTextBox10.CustomButton.Visible = false;
            this.metroTextBox10.Lines = new string[0];
            this.metroTextBox10.Location = new System.Drawing.Point(137, 136);
            this.metroTextBox10.MaxLength = 32767;
            this.metroTextBox10.Name = "metroTextBox10";
            this.metroTextBox10.PasswordChar = '\0';
            this.metroTextBox10.PromptText = "Enter Occupation...";
            this.metroTextBox10.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox10.SelectedText = "";
            this.metroTextBox10.SelectionLength = 0;
            this.metroTextBox10.SelectionStart = 0;
            this.metroTextBox10.ShortcutsEnabled = true;
            this.metroTextBox10.Size = new System.Drawing.Size(321, 23);
            this.metroTextBox10.TabIndex = 30;
            this.metroTextBox10.UseSelectable = true;
            this.metroTextBox10.WaterMark = "Enter Occupation...";
            this.metroTextBox10.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox10.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox9
            // 
            // 
            // 
            // 
            this.metroTextBox9.CustomButton.Image = null;
            this.metroTextBox9.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.metroTextBox9.CustomButton.Name = "";
            this.metroTextBox9.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox9.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox9.CustomButton.TabIndex = 1;
            this.metroTextBox9.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox9.CustomButton.UseSelectable = true;
            this.metroTextBox9.CustomButton.Visible = false;
            this.metroTextBox9.Lines = new string[0];
            this.metroTextBox9.Location = new System.Drawing.Point(137, 96);
            this.metroTextBox9.MaxLength = 32767;
            this.metroTextBox9.Name = "metroTextBox9";
            this.metroTextBox9.PasswordChar = '\0';
            this.metroTextBox9.PromptText = "Enter PhoneNumber...";
            this.metroTextBox9.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox9.SelectedText = "";
            this.metroTextBox9.SelectionLength = 0;
            this.metroTextBox9.SelectionStart = 0;
            this.metroTextBox9.ShortcutsEnabled = true;
            this.metroTextBox9.Size = new System.Drawing.Size(321, 23);
            this.metroTextBox9.TabIndex = 29;
            this.metroTextBox9.UseSelectable = true;
            this.metroTextBox9.WaterMark = "Enter PhoneNumber...";
            this.metroTextBox9.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox9.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(21, 96);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(116, 13);
            this.Label15.TabIndex = 28;
            this.Label15.Text = "Fathers PhoneNumber:";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(21, 136);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(103, 13);
            this.Label14.TabIndex = 27;
            this.Label14.Text = "Fathers Occupation:";
            // 
            // metroTextBox8
            // 
            // 
            // 
            // 
            this.metroTextBox8.CustomButton.Image = null;
            this.metroTextBox8.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.metroTextBox8.CustomButton.Name = "";
            this.metroTextBox8.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox8.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox8.CustomButton.TabIndex = 1;
            this.metroTextBox8.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox8.CustomButton.UseSelectable = true;
            this.metroTextBox8.CustomButton.Visible = false;
            this.metroTextBox8.Lines = new string[0];
            this.metroTextBox8.Location = new System.Drawing.Point(137, 56);
            this.metroTextBox8.MaxLength = 32767;
            this.metroTextBox8.Name = "metroTextBox8";
            this.metroTextBox8.PasswordChar = '\0';
            this.metroTextBox8.PromptText = "Enter Name...";
            this.metroTextBox8.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox8.SelectedText = "";
            this.metroTextBox8.SelectionLength = 0;
            this.metroTextBox8.SelectionStart = 0;
            this.metroTextBox8.ShortcutsEnabled = true;
            this.metroTextBox8.Size = new System.Drawing.Size(321, 23);
            this.metroTextBox8.TabIndex = 22;
            this.metroTextBox8.UseSelectable = true;
            this.metroTextBox8.WaterMark = "Enter Name...";
            this.metroTextBox8.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox8.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(21, 56);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(76, 13);
            this.Label13.TabIndex = 26;
            this.Label13.Text = "Fathers Name:";
            // 
            // CheckBox3
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.Location = new System.Drawing.Point(187, 28);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(40, 17);
            this.CheckBox3.TabIndex = 25;
            this.CheckBox3.Text = "No";
            this.CheckBox3.UseVisualStyleBackColor = true;
            // 
            // CheckBox2
            // 
            this.CheckBox2.AutoSize = true;
            this.CheckBox2.Location = new System.Drawing.Point(135, 28);
            this.CheckBox2.Name = "CheckBox2";
            this.CheckBox2.Size = new System.Drawing.Size(44, 17);
            this.CheckBox2.TabIndex = 24;
            this.CheckBox2.Text = "Yes";
            this.CheckBox2.UseVisualStyleBackColor = true;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(21, 29);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(78, 13);
            this.Label12.TabIndex = 0;
            this.Label12.Text = "Have Parents?";
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.BackColor = System.Drawing.Color.Blue;
            this.btnSaveAll.ForeColor = System.Drawing.Color.White;
            this.btnSaveAll.Location = new System.Drawing.Point(692, 506);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(100, 44);
            this.btnSaveAll.TabIndex = 22;
            this.btnSaveAll.Text = "Save All";
            this.btnSaveAll.UseVisualStyleBackColor = false;
            // 
            // opfl
            // 
            this.opfl.FileName = "openFileDialog1";
            // 
            // ForGuardianParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 648);
            this.Controls.Add(this.GroupBox2);
            this.Name = "ForGuardianParent";
            this.Text = "ForGuardianParent";
            this.Load += new System.EventHandler(this.ForGuardianParent_Load_1);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.GroupBox GroupBox4;
        private MetroFramework.Controls.MetroTextBox metroTextBox17;
        private System.Windows.Forms.Label label21;
        private MetroFramework.Controls.MetroTextBox metroTextBox16;
        private MetroFramework.Controls.MetroTextBox metroTextBox15;
        private System.Windows.Forms.Label Label20;
        private System.Windows.Forms.Label Label19;
        private MetroFramework.Controls.MetroTextBox metroTextBox14;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label Label18;
        private MetroFramework.Controls.MetroTextBox metroTextBox13;
        private MetroFramework.Controls.MetroTextBox metroTextBox12;
        private System.Windows.Forms.Label Label17;
        private MetroFramework.Controls.MetroTextBox metroTextBox11;
        private System.Windows.Forms.Label Label16;
        private MetroFramework.Controls.MetroTextBox metroTextBox10;
        private MetroFramework.Controls.MetroTextBox metroTextBox9;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.Label Label14;
        private MetroFramework.Controls.MetroTextBox metroTextBox8;
        private System.Windows.Forms.Label Label13;
        private System.Windows.Forms.CheckBox CheckBox3;
        private System.Windows.Forms.CheckBox CheckBox2;
        private System.Windows.Forms.Label Label12;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbnBack;
        private System.Windows.Forms.OpenFileDialog opfl;
    }
}