using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Resources;


namespace _6955_PRG521_FA2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {   
        }

        private void btnLogRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register Register = new Register();
            Register.Show();
            
        }

        private void btnLogCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLogUsername_TextChanged(object sender, EventArgs e)
        {
            //txtLogUsername.Clear();
        }

        private void txtLogPass_TextChanged(object sender, EventArgs e)
        {
            //txtLogPass.Clear();
        }

        private void btnLogLogin_Click(object sender, EventArgs e)
        {
            if (txtLogUsername.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogUsername.Focus();
                return;
            }
            if (txtLogPass.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogPass.Focus();
                return;
            }
            try
            {
                String UsrLogin = txtLogUsername.Text;
                String UsrPW = txtLogPass.Text;
                String SQLUsrLogin = "";
                String SQLUsrPW = "";
                

                SqlConnection connection = new SqlConnection(("Data Source=ORACLE\\SQLEXPRESS;Initial Catalog=6955_FA2_PRG521;Integrated Security=True"));
                connection.Open();
                
                SqlCommand LoginSelect = new SqlCommand();

                LoginSelect = new SqlCommand("SELECT [UserID],[Firstname],[Lastname],[Username],[Password],[Email],[ContactNumber],[OrgName],[Profile] FROM [Users] WHERE [Username] like '" + UsrLogin + "' AND [Password] like '" + UsrPW +"'", connection);
                SqlDataReader sql_reader;
                sql_reader = LoginSelect.ExecuteReader();

                if (sql_reader.HasRows)
                {
                    while (sql_reader.Read())
                    {
                        SQLUsrLogin = sql_reader.GetString(3).Trim();
                        SQLUsrPW = sql_reader.GetString(4).Trim();
                        Program.UsrProfileApp = sql_reader.GetString(8).Trim();
                        Program.UsrNameApp = sql_reader.GetString(1).Trim();
                        Program.UsrLastNameApp = sql_reader.GetString(2).Trim();
                        Program.UsrOrgNameApp = sql_reader.GetString(7).Trim();
                        Program.UsrContactNoApp = sql_reader.GetString(6).Trim();
                        Program.UsrContactMailApp = sql_reader.GetString(5).Trim();
                    }

                }
                
                if (sql_reader.HasRows)
                {

                    MessageBox.Show("You have logged in successfully " + Program.UsrNameApp + " " +Program.UsrLastNameApp);
                    //Hide the login form
                    this.Hide();

                    if (Program.UsrProfileApp == "Admin")
                    {
                        AdminProfile adminProfile = new AdminProfile();
                        adminProfile.Show();
                    }
                    else if (Program.UsrProfileApp == "NGO")
                    {
                        NGOProfile nGOProfile = new NGOProfile();
                        nGOProfile.Show();
                    }
                    else
                    {
                        Donations donations = new Donations();
                        donations.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtLogUsername.Clear();
                    txtLogPass.Clear();
                    txtLogUsername.Focus();

                }
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
