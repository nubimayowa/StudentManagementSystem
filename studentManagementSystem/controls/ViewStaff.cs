using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using studentManagementSystem.controls;
using System.Runtime.InteropServices;
namespace studentManagementSystem.controls
{
    public partial class ViewStaff : UserControl
    {

        
        public ViewStaff()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            EditGuarantor add = new EditGuarantor();
            add.Show();
        }

        private void ViewStaff_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
