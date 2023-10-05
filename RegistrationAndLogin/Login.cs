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

namespace RegistrationAndLogin
{
    public partial class Login : Form
    {
        SqlDataReader reader;
        SqlConnection sqlConnection;
        SqlCommand cmd;
        string sql = "Server = DESKTOP-RA0DIP0\\SQLEXPRESS;Database = LoginTable;Trusted_Connection = True; Encrypt = false;TrustServerCertificate = true";

        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(sql);
            sqlConnection.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passwordField.Text != string.Empty || usernameField.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from LoginTable where username='" + usernameField.Text + "' and password='" + passwordField.Text + "'", sqlConnection);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string user = reader.GetString("username");
                    string password = reader.GetString("password");
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                    this.Close();
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
