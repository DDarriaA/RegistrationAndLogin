using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationAndLogin
{
    public partial class Registration : Form
    {
        SqlDataReader reader;
        SqlConnection sqlConnection;
        SqlCommand cmd;
        string sql = "Server = DESKTOP-RA0DIP0\\SQLEXPRESS;Database = LoginTable;Trusted_Connection = True; Encrypt = false;TrustServerCertificate = true";

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            //string sql = "Server = DESKTOP - RA0DIP0\\SQLEXPRESS; Database = tickets2; Trusted_Connection = True; Encrypt = false; TrustServerCertificate = true ";
            sqlConnection = new SqlConnection(sql);
            sqlConnection.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (confirmpasswordField.Text != string.Empty || passwordField.Text != string.Empty || usernameField.Text != string.Empty)
            {
                if (passwordField.Text == confirmpasswordField.Text)
                {
                    cmd = new SqlCommand("select * from LoginTable where username='" + usernameField.Text + "' and password='" + passwordField.Text + "'", sqlConnection);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reader.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        reader.Close();
                        cmd = new SqlCommand("insert into LoginTable values(@username,@password)", sqlConnection);
                        cmd.Parameters.AddWithValue("username", usernameField.Text);
                        cmd.Parameters.AddWithValue("password", passwordField.Text);
                        //cmd.Parameters.AddWithValue("id");
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
