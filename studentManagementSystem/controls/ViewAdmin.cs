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
    public partial class ViewAdmin : UserControl
    {
        public ViewAdmin()
        {
            InitializeComponent();
        }

        private void ViewAdmin_Load(object sender, EventArgs e)
        {
            metroComboBox1.SelectedItem = "Search With";
        }
    }
}
