namespace studentManagementSystem
{
    partial class loginPage
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
            this.txtuserName = new MetroFramework.Controls.MetroTextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnrest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassWord = new MetroFramework.Controls.MetroTextBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtuserName
            // 
            // 
            // 
            // 
            this.txtuserName.CustomButton.Image = null;
            this.txtuserName.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtuserName.CustomButton.Name = "";
            this.txtuserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtuserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtuserName.CustomButton.TabIndex = 1;
            this.txtuserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtuserName.CustomButton.UseSelectable = true;
            this.txtuserName.CustomButton.Visible = false;
            this.txtuserName.Lines = new string[0];
            this.txtuserName.Location = new System.Drawing.Point(172, 53);
            this.txtuserName.MaxLength = 32767;
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.PasswordChar = '\0';
            this.txtuserName.PromptText = "Enter your userName...";
            this.txtuserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtuserName.SelectedText = "";
            this.txtuserName.SelectionLength = 0;
            this.txtuserName.SelectionStart = 0;
            this.txtuserName.ShortcutsEnabled = true;
            this.txtuserName.Size = new System.Drawing.Size(153, 23);
            this.txtuserName.TabIndex = 0;
            this.txtuserName.UseSelectable = true;
            this.txtuserName.WaterMark = "Enter your userName...";
            this.txtuserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtuserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnrest);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.btnlogin);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.txtpassWord);
            this.GroupBox1.Controls.Add(this.txtuserName);
            this.GroupBox1.Location = new System.Drawing.Point(40, 66);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(436, 279);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // btnrest
            // 
            this.btnrest.BackColor = System.Drawing.Color.Blue;
            this.btnrest.ForeColor = System.Drawing.Color.White;
            this.btnrest.Location = new System.Drawing.Point(240, 176);
            this.btnrest.Name = "btnrest";
            this.btnrest.Size = new System.Drawing.Size(75, 45);
            this.btnrest.TabIndex = 4;
            this.btnrest.Text = "Reset";
            this.btnrest.UseVisualStyleBackColor = false;
            this.btnrest.Click += new System.EventHandler(this.btnrest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "passWord:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Blue;
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(134, 176);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(75, 45);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "userName:";
            // 
            // txtpassWord
            // 
            // 
            // 
            // 
            this.txtpassWord.CustomButton.Image = null;
            this.txtpassWord.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.txtpassWord.CustomButton.Name = "";
            this.txtpassWord.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtpassWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpassWord.CustomButton.TabIndex = 1;
            this.txtpassWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpassWord.CustomButton.UseSelectable = true;
            this.txtpassWord.CustomButton.Visible = false;
            this.txtpassWord.Lines = new string[0];
            this.txtpassWord.Location = new System.Drawing.Point(172, 107);
            this.txtpassWord.MaxLength = 32767;
            this.txtpassWord.Name = "txtpassWord";
            this.txtpassWord.PasswordChar = '\0';
            this.txtpassWord.PromptText = "Enter Your passWord...";
            this.txtpassWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpassWord.SelectedText = "";
            this.txtpassWord.SelectionLength = 0;
            this.txtpassWord.SelectionStart = 0;
            this.txtpassWord.ShortcutsEnabled = true;
            this.txtpassWord.Size = new System.Drawing.Size(153, 23);
            this.txtpassWord.TabIndex = 1;
            this.txtpassWord.UseSelectable = true;
            this.txtpassWord.WaterMark = "Enter Your passWord...";
            this.txtpassWord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpassWord.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // loginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 382);
            this.Controls.Add(this.GroupBox1);
            this.Name = "loginPage";
            this.Text = "AdminPage";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtuserName;
        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtpassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnrest;
    }
}