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
    public partial class StaffRegistration : UserControl
    {
        byte[] imgbyt = null;
        public StaffRegistration()
        {
            InitializeComponent();
        }

        private void StaffRegistration_Load(object sender, EventArgs e)
        {
            metroComboBox1.Text = "Select Staff Role";
        }

        private void pbpic_Click(object sender, EventArgs e)
        {

        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }
        public  void Opbl2()

        {
            Opblstaff.Filter = "jpg|*.jpg";
            DialogResult res = Opblstaff.ShowDialog();
            if (res == DialogResult.OK)
            {
                pbpic.Image = Image.FromFile(Opblstaff.FileName);
                ImageConverter imgconv = new ImageConverter();
                imgbyt = (System.Byte[])imgconv.ConvertTo(pbpic.Image, Type.GetType("System.Byte[]"));
            }

        }
        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Opbl2();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            Opbl2();
        }

        
    }
}
