using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _6955_PRG521_FA2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(("Data Source = ORACLE\\SQLEXPRESS; Initial Catalog = FA2_PRG521_6955; Integrated Security = True"));
        }

        private void btnRegCancel_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Login login = new Login();
            login.Show();
                     
            
        }

        private void btnRSave_Click(object sender, EventArgs e)
        {
            
            String ProfType = "";

            if (rbtnRegNGO.Checked == true)
            {
                ProfType = "NGO";
            }
            else if (rbtnRegDonor.Checked == true)
            {
                ProfType = "Donor";
            }

            String strSQLInsert = "INSERT INTO [Users] ([Firstname], [Lastname], [Username], [Password], [Email], [ContactNumber], [OrgName], [Profile]) VALUES ('" + 
                                    txtRegName.Text + "', '" + txtRegSurname.Text+ "', '" + txtRegUser.Text+ "', '" + txtRegPass.Text+ "', '" + txtRegEmail.Text+ "', '" + txtRegCell.Text+ "', '" + txtRegNGOName.Text+ "', '" + ProfType + "')";


            
            SqlConnection connection = new SqlConnection(("Data Source=ORACLE\\SQLEXPRESS;Initial Catalog=6955_FA2_PRG521;Integrated Security=True"));

            using (SqlCommand WriteToDb = new SqlCommand(strSQLInsert, connection))
            {
            
                connection.Open();
                
                int result = WriteToDb.ExecuteNonQuery();

                if (result > 0)
                    MessageBox.Show("Data Saved");

            connection.Close();
            }

            txtRegName.Clear();
            txtRegSurname.Clear();
            txtRegPass.Clear();
            txtRegUser.Clear();
            txtRegCell.Clear();
            txtRegEmail.Clear();
            txtRegNGOName.Clear();
            txtRegName.Focus();

            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void txtRegNGOName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDoReq_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegCell_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegName_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbtnRegNGO_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRegNGO.Checked == true)
            {
                txtRegNGOName.Visible = true;
                lblNgoName.Visible = true;
            }
            else 
            {
                txtRegNGOName.Visible = false;
                lblNgoName.Visible = false;
            }
        }

        private void rbtnRegDonor_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRegNGO.Checked == true)
            {
                txtRegNGOName.Visible = false;
                lblNgoName.Visible = false;
            }
        }
    }
}
