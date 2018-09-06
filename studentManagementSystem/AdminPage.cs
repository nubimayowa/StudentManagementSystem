using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studentManagementSystem.controls;

namespace studentManagementSystem
{
    public partial class AdminPage : MetroFramework.Forms.MetroForm
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void createAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void viewAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //panel1.Controls.Clear();
            //ViewStudents add = new ViewStudents();
            //panel1.Controls.Add(add);
        }

        private void studentRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {


           

        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

          

        }

        private void studentsRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            StudentRegistration add = new StudentRegistration();
            panel1.Controls.Add(add);

        }

        private void viewStudentsInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ViewStudents add = new ViewStudents();
            panel1.Controls.Add(add);

        }

        private void createAdminToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            AddAdmin add = new AddAdmin();
            panel1.Controls.Add(add);


        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //panel1.Controls.Clear();
            
            AdminPage add = new AdminPage();
           
            panel1.Controls.Clear();
            panel1.Controls.Add(pictureBox1);
            


        }

        private void staffRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            StaffRegistration add = new StaffRegistration();
            panel1.Controls.Add(add);
        }

        private void viewStaffInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            ViewStaff add = new ViewStaff();
            panel1.Controls.Add(add);
        }
    }
    
}
//<h1 class="animated wobble" >This is me </h1>