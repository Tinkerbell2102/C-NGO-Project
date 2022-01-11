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
    public partial class Donations : Form
    {
        public Donations()
        {
            InitializeComponent();
        }

        private void btnpiLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnpiClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbxNGO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Donations_Load(object sender, EventArgs e)
        {
            lblDonorDetails.Text = Program.UsrNameApp + " " + Program.UsrLastNameApp + Environment.NewLine +
                                Program.UsrOrgNameApp + Environment.NewLine +
                                "Contact No: " + Program.UsrContactNoApp + Environment.NewLine +
                                "Email: " + Program.UsrContactMailApp;


            //Set Dropdown List Values
            SqlConnection connection = new SqlConnection(("Data Source=ORACLE\\SQLEXPRESS;Initial Catalog=6955_FA2_PRG521;Integrated Security=True"));
            connection.Open();
            
            SqlCommand NGOList = new SqlCommand();
            NGOList = new SqlCommand("SELECT Distinct [OrgName] FROM [NGO] Order By [OrgName] Asc", connection);

            SqlDataReader sql_reader;
            sql_reader = NGOList.ExecuteReader();

            if (sql_reader.HasRows)
            {

                while (sql_reader.Read())
                {
                    cmbNgoName.Items.Add(sql_reader.GetString(0).Trim());
                }
            }
            connection.Close();

        }

        private void btnDonationHist_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(("Data Source=ORACLE\\SQLEXPRESS;Initial Catalog=6955_FA2_PRG521;Integrated Security=True"));
                connection.Open();

                SqlCommand DonHistEventsSelect = new SqlCommand();

                String HistDateSelect = dtDonorFormHist.Value.ToString();

                DonHistEventsSelect = new SqlCommand("SELECT [ID],[OrgName],[DonationtDetail],[RequestStatus],[EventDate],[EventName],[User],[DonationAmmount] FROM [DonorRequest] Where[User] = '" + Program.UsrNameApp + "' and [RequestStatus] = 'Accepted' and [EventDate] < '" + HistDateSelect + "' Order By [EventDate] Asc", connection);
                SqlDataReader sql_reader;
                sql_reader = DonHistEventsSelect.ExecuteReader();

                if (sql_reader.HasRows)
                {


                    String DonHistEventList = "";
                    while (sql_reader.Read())
                    {
                        DonHistEventList = DonHistEventList +
                                    sql_reader.GetDateTime(4).ToString() + " - " +
                                    sql_reader.GetString(5).Trim() + " - " +
                                    sql_reader.GetString(2).Trim() + Environment.NewLine;

                    }
                    rtxtDonationHist.Text = "Event Date - Event Name - Event Description" + Environment.NewLine + DonHistEventList;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnDonationSubmit_Click(object sender, EventArgs e)
        {
            String strSQLInsert = "INSERT INTO [DonorRequest] ([OrgName],[DonationtDetail],[RequestStatus],[EventDate],[EventName],[User],[DonationAmmount]) VALUES ('" +
                                   cmbNgoName.Text + "', '" + txtDonationType.Text + "', 'Pending', '" + dtDonationEventDate.Value + "', '" + cmbNGOEventName.Text + "', '" + Program.UsrNameApp + " " + Program.UsrLastNameApp + "', '" + nudDonationAmmount.Value + "')";

            SqlConnection connection = new SqlConnection(("Data Source=ORACLE\\SQLEXPRESS;Initial Catalog=6955_FA2_PRG521;Integrated Security=True"));

            using (SqlCommand WriteEventToDb = new SqlCommand(strSQLInsert, connection))
            {

                connection.Open();

                int result = WriteEventToDb.ExecuteNonQuery();

                if (result > 0)
                    MessageBox.Show("Data Saved");

                connection.Close();
            }
        }

        private void cmbNGOEventName_SelectedIndexChanged(object sender, EventArgs e)
        { 
        
        }

            private void cmbNgoName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNGOEventName.Items.Clear();
            cmbNGOEventName.Text = "";
            //Set Dropdown List Values
            SqlConnection connection = new SqlConnection(("Data Source=ORACLE\\SQLEXPRESS;Initial Catalog=6955_FA2_PRG521;Integrated Security=True"));
            connection.Open();

            SqlCommand NGOEventList = new SqlCommand();
            NGOEventList = new SqlCommand("SELECT Distinct [EventName] FROM [NGO] where [OrgName] = '" + cmbNgoName.SelectedItem.ToString() + "' Order By [EventName] Asc", connection);

            SqlDataReader sql_reader;
            sql_reader = NGOEventList.ExecuteReader();

            if (sql_reader.HasRows)
            {

                while (sql_reader.Read())
                {
                    cmbNGOEventName.Items.Add(sql_reader.GetString(0).Trim());
                }
            }
            connection.Close();
        }
    }
 }

