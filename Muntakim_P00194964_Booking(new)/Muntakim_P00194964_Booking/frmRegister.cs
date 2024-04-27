using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Muntakim_P00194964_Booking
{
    public partial class frmRegister : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Booking.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        public frmRegister()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtConPassword.UseSystemPasswordChar = true;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            //Signup Button Function

            conn.Open();

            if (txtUser.Text != "" && txtPassword.Text != "" && txtConPassword.Text != "")
            {
                if (txtPassword.Text == txtConPassword.Text)
                {
                    cmd = new SqlCommand("select * from tblUser where username='" +txtUser.Text+"'",conn);
                        dr= cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        dr.Close();
                        cmd= new SqlCommand("insert into tblUser values(@username, @password, @utype)", conn);
                        cmd.Parameters.AddWithValue("username", txtUser.Text);
                        cmd.Parameters.AddWithValue("password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("utype", "user");

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("please enter both password same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else
            {
                MessageBox.Show("Please enter value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();  

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog(); 
        }

        private void txtConPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
