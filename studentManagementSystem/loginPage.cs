using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace studentManagementSystem
{
    public partial class loginPage : MetroFramework.Forms.MetroForm

    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnrest_Click(object sender, EventArgs e)
        {
            txtuserName.Text = null;
            txtpassWord.Text = null;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuserName.Text == "")
            {
                MessageBox.Show("Check your username field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else if (txtpassWord.Text == "")
            {
                MessageBox.Show("check your password field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                    string connectionstring = null;
                    connectionstring = "data source=(local);initial catalog=Mayowaa;integrated security=True;MultipleActiveResultSets=True;";
                    SqlConnection con = new SqlConnection(connectionstring);
                    SqlCommand query = new SqlCommand
                    {
                        Connection = con,
                        CommandType = CommandType.StoredProcedure,

                    };
                    //int role;
                    query.CommandText = "AdminPage";   //stored procedure Name
                    con.Open();
                    query.CommandType = CommandType.StoredProcedure;
                    query.Parameters.AddWithValue("@UserName", txtuserName.Text.ToString());   //for username 
                    query.Parameters.AddWithValue("@PassWord", txtpassWord.Text.ToString());  //for password


                    // here down makes the difference
                    int usercount = (Int32)query.ExecuteScalar();// for taking single value

                    if (usercount == 1)
                    {
                        // comparing users from table 

                        this.Hide();
                        AdminPage app = new AdminPage();
                        app.Show();


                    }

                    else
                    {
                        MessageBox.Show("username or password doesnt exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                

            }

        }


        


    }
}

