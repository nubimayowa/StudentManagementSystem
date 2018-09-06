namespace studentManagementSystem
{
    partial class AdminPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAdminToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAdminToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.staffMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStaffInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAdminToolStripMenuItem,
            this.viewAdminToolStripMenuItem,
            this.staffMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1299, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createAdminToolStripMenuItem
            // 
            this.createAdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAdminToolStripMenuItem1,
            this.viewAdminToolStripMenuItem1,
            this.homeToolStripMenuItem});
            this.createAdminToolStripMenuItem.Name = "createAdminToolStripMenuItem";
            this.createAdminToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.createAdminToolStripMenuItem.Text = "Admin Menu";
            this.createAdminToolStripMenuItem.Click += new System.EventHandler(this.createAdminToolStripMenuItem_Click);
            // 
            // createAdminToolStripMenuItem1
            // 
            this.createAdminToolStripMenuItem1.Name = "createAdminToolStripMenuItem1";
            this.createAdminToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.createAdminToolStripMenuItem1.Text = "Create Admin";
            this.createAdminToolStripMenuItem1.Click += new System.EventHandler(this.createAdminToolStripMenuItem1_Click);
            // 
            // viewAdminToolStripMenuItem1
            // 
            this.viewAdminToolStripMenuItem1.Name = "viewAdminToolStripMenuItem1";
            this.viewAdminToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.viewAdminToolStripMenuItem1.Text = "View Admin";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // viewAdminToolStripMenuItem
            // 
            this.viewAdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsRegistrationToolStripMenuItem,
            this.viewStudentsInformationToolStripMenuItem});
            this.viewAdminToolStripMenuItem.Name = "viewAdminToolStripMenuItem";
            this.viewAdminToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.viewAdminToolStripMenuItem.Text = "Student Menu";
            this.viewAdminToolStripMenuItem.Click += new System.EventHandler(this.viewAdminToolStripMenuItem_Click);
            // 
            // studentsRegistrationToolStripMenuItem
            // 
            this.studentsRegistrationToolStripMenuItem.Name = "studentsRegistrationToolStripMenuItem";
            this.studentsRegistrationToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.studentsRegistrationToolStripMenuItem.Text = "Students Registration";
            this.studentsRegistrationToolStripMenuItem.Click += new System.EventHandler(this.studentsRegistrationToolStripMenuItem_Click);
            // 
            // viewStudentsInformationToolStripMenuItem
            // 
            this.viewStudentsInformationToolStripMenuItem.Name = "viewStudentsInformationToolStripMenuItem";
            this.viewStudentsInformationToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.viewStudentsInformationToolStripMenuItem.Text = "View Students information";
            this.viewStudentsInformationToolStripMenuItem.Click += new System.EventHandler(this.viewStudentsInformationToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 587);
            this.panel1.TabIndex = 1;
            // 
            // staffMenuToolStripMenuItem
            // 
            this.staffMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffRegistrationToolStripMenuItem,
            this.viewStaffInformationToolStripMenuItem});
            this.staffMenuToolStripMenuItem.Name = "staffMenuToolStripMenuItem";
            this.staffMenuToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.staffMenuToolStripMenuItem.Text = "Staff Menu";
            // 
            // staffRegistrationToolStripMenuItem
            // 
            this.staffRegistrationToolStripMenuItem.Name = "staffRegistrationToolStripMenuItem";
            this.staffRegistrationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.staffRegistrationToolStripMenuItem.Text = "Staff Registration";
            this.staffRegistrationToolStripMenuItem.Click += new System.EventHandler(this.staffRegistrationToolStripMenuItem_Click);
            // 
            // viewStaffInformationToolStripMenuItem
            // 
            this.viewStaffInformationToolStripMenuItem.Name = "viewStaffInformationToolStripMenuItem";
            this.viewStaffInformationToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.viewStaffInformationToolStripMenuItem.Text = "View Staff Information";
            this.viewStaffInformationToolStripMenuItem.Click += new System.EventHandler(this.viewStaffInformationToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::studentManagementSystem.Properties.Resources.au;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1339, 587);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 667);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsInformationToolStripMenuItem;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem createAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAdminToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewAdminToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStaffInformationToolStripMenuItem;
    }
}