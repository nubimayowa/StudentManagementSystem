using studentManagementSystem.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentManagementSystem
{
    public partial class ForGuardianParent : MetroFramework.Forms.MetroForm
    {
        public ForGuardianParent()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void ComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void ForGuardianParent_Load(object sender, EventArgs e)
        {
           
            // richTextBox1.Text = "Enter Current Address";
            // richTextBox2.Text = "Enter Permanent Address";

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void ForGuardianParent_Load_1(object sender, EventArgs e)
        {
            metroComboBox1.SelectedItem = "Select Means of Identification";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

            



            AdminPage adminPage = new AdminPage();
            adminPage.panel1.Controls.Clear();
            StudentRegistration studentregistration = new StudentRegistration();
            
           
            adminPage.panel1.Controls.Add(studentregistration);
            this.Close();

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            
        }
    }
}
