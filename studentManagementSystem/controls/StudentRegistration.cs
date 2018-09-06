using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace studentManagementSystem.controls
{
    public partial class StudentRegistration : UserControl
    {
        byte[] imgbyt = null;
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void Opbll()
        {
            opbl.Filter = "jpg|*.jpg";
            DialogResult res = opbl.ShowDialog();
            if (res == DialogResult.OK)
            {
                pbpic.Image = Image.FromFile(opbl.FileName);
                ImageConverter imgconv = new ImageConverter();
                imgbyt = (System.Byte[])imgconv.ConvertTo(pbpic.Image, Type.GetType("System.Byte[]"));
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            metroComboBox1.SelectedItem = "Select Religion";
          
            // richTextBox1.Text = "Enter Current Address";
            // richTextBox2.Text = "Enter Permanent Address";


           
        } 

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Opbll();
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ForGuardianParents forGuardianParents = new ForGuardianParents();
            //AdminPage adminPage = new AdminPage();
            //adminPage.panel1.Controls.Clear();
            //adminPage.panel1.Controls.Add(forGuardianParents);

            //AdminPage.panel1.Controls.Clear();
            //ForGuardianParents add = new ForGuardianParents();
            //AdminPage.panel1.Controls.Add(add);



            //panel1.Controls.Clear();
            //StudentRegistration add = new StudentRegistration();
            //panel1.Controls.Add(add);

            





        }

        private void Label23_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ForGuardianParent ap = new ForGuardianParent();
            ap.Show();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminPage add = new AdminPage();
            add.Show();

        }

        private void pbpic_Click(object sender, EventArgs e)
        {

        }
    }
}
