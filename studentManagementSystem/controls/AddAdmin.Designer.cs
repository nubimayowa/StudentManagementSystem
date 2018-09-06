namespace studentManagementSystem.controls
{
    partial class AddAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNewPassWord = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewUserName = new MetroFramework.Controls.MetroTextBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.txtNewPassWord);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.btnClear);
            this.GroupBox1.Controls.Add(this.btnAdd);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.txtNewUserName);
            this.GroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.GroupBox1.Location = new System.Drawing.Point(377, 128);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(595, 337);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Add New Admin";
            // 
            // txtNewPassWord
            // 
            // 
            // 
            // 
            this.txtNewPassWord.CustomButton.Image = null;
            this.txtNewPassWord.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtNewPassWord.CustomButton.Name = "";
            this.txtNewPassWord.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewPassWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPassWord.CustomButton.TabIndex = 1;
            this.txtNewPassWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPassWord.CustomButton.UseSelectable = true;
            this.txtNewPassWord.CustomButton.Visible = false;
            this.txtNewPassWord.Lines = new string[0];
            this.txtNewPassWord.Location = new System.Drawing.Point(292, 139);
            this.txtNewPassWord.MaxLength = 32767;
            this.txtNewPassWord.Name = "txtNewPassWord";
            this.txtNewPassWord.PasswordChar = '\0';
            this.txtNewPassWord.PromptText = "Enter PassWord...";
            this.txtNewPassWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPassWord.SelectedText = "";
            this.txtNewPassWord.SelectionLength = 0;
            this.txtNewPassWord.SelectionStart = 0;
            this.txtNewPassWord.ShortcutsEnabled = true;
            this.txtNewPassWord.Size = new System.Drawing.Size(133, 23);
            this.txtNewPassWord.TabIndex = 5;
            this.txtNewPassWord.UseSelectable = true;
            this.txtNewPassWord.WaterMark = "Enter PassWord...";
            this.txtNewPassWord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPassWord.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(207, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PassWord:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Blue;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(350, 220);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 41);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(223, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(207, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserName:";
            // 
            // txtNewUserName
            // 
            // 
            // 
            // 
            this.txtNewUserName.CustomButton.Image = null;
            this.txtNewUserName.CustomButton.Location = new System.Drawing.Point(111, 1);
            this.txtNewUserName.CustomButton.Name = "";
            this.txtNewUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewUserName.CustomButton.TabIndex = 1;
            this.txtNewUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewUserName.CustomButton.UseSelectable = true;
            this.txtNewUserName.CustomButton.Visible = false;
            this.txtNewUserName.Lines = new string[0];
            this.txtNewUserName.Location = new System.Drawing.Point(292, 68);
            this.txtNewUserName.MaxLength = 32767;
            this.txtNewUserName.Name = "txtNewUserName";
            this.txtNewUserName.PasswordChar = '\0';
            this.txtNewUserName.PromptText = "Enter UserName...";
            this.txtNewUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewUserName.SelectedText = "";
            this.txtNewUserName.SelectionLength = 0;
            this.txtNewUserName.SelectionStart = 0;
            this.txtNewUserName.ShortcutsEnabled = true;
            this.txtNewUserName.Size = new System.Drawing.Size(133, 23);
            this.txtNewUserName.TabIndex = 0;
            this.txtNewUserName.UseSelectable = true;
            this.txtNewUserName.WaterMark = "Enter UserName...";
            this.txtNewUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::studentManagementSystem.Properties.Resources.au;
            this.Controls.Add(this.GroupBox1);
            this.Name = "AddAdmin";
            this.Size = new System.Drawing.Size(1339, 580);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private MetroFramework.Controls.MetroTextBox txtNewUserName;
        private MetroFramework.Controls.MetroTextBox txtNewPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
    }
}
