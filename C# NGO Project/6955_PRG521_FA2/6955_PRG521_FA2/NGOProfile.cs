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
    public partial class NGOProfile : Form
    {
        public NGOProfile()
        {
            InitializeComponent();
        }

        private void btnNGOLogout_Click(object sender, EventArgs e)
        {

            this.Hide();
            Login login = new Login();
            login.Show();

        }

        private void btnNGOClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NGOProfile_Load(object sender, EventArgs e)
        {

            lblNGODetail.Text = Program.UsrNameApp + " " + Program.UsrLastNameApp + Environment.NewLine +
                                Program.UsrOrgNameApp + Environment.NewLine +
                                "Contact No: " + Program.UsrContactNoApp + Environment.NewLine+
                                "Email: " + Program.UsrContactMailApp;


        }

        private void btnNNGOGetCurEvents_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(("Data Source=ORACLE\\SQLEXPRESS;Initial Catalog=6955_FA2_PRG521;Integrated Security=True"));
                connection.Open();

                SqlCommand NGOCurrEventsSelect = new SqlCommand();

                NGOCurrEventsSelect = new SqlCommand("SELECT [ID], [OrgName], [DonationtDetail], [RequestStatus], [EventDate], [EventName] FROM[NGO] Where[OrgName] = '" + Program.UsrOrgNameApp + "' and [EventDate] > '" + System.DateTime.Today + "'Order By [EventDate] Asc", connection);
                SqlDataReader sql_reader;
                sql_reader = NGOCurrEventsSelect.ExecuteReader();

                if (sql_reader.HasRows)
                {


                    String EventList = "";
                    while (sql_reader.Read())
                    {
                        EventList = EventList +
                                    sql_reader.GetDateTime(4).ToString() + " - " + 
                                    sql_reader.GetString(5).Trim() + " - " +
                                    sql_reader.GetString(3).Trim() + " - " +
                                    sql_reader.GetString(2).Trim() + Environment.NewLine;

                    }
                    rtxtNGOCurrentEvents.Text = "Event Date - Event Name - Event Status - Event Description" + Environment.NewLine + EventList;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(("Data Source=ORACLE\\SQLEXPRESS;Initial Catalog=6955_FA2_PRG521;Integrated Security=True"));
                connection.Open();

                SqlCommand NGOHistEventsSelect = new SqlCommand();

                String HistDateSelect = dtNGOFromHist.Value.ToString();

                NGOHistEventsSelect = new SqlCommand("SELECT [ID], [OrgName], [DonationtDetail], [RequestStatus], [EventDate], [EventName] FROM[NGO] Where[OrgName] = '" + Program.UsrOrgNameApp + "' and[RequestStatus] = 'Accepted' and [EventDate] < '" + HistDateSelect + "' Order By [EventDate] Asc", connection);
                SqlDataReader sql_reader;
                sql_reader = NGOHistEventsSelect.ExecuteReader();

                if (sql_reader.HasRows)
                {


                    String HistEventList = "";
                    while (sql_reader.Read())
                    {
                        HistEventList = HistEventList +
                                    sql_reader.GetDateTime(4).ToString() + " - " +
                                    sql_reader.GetString(5).Trim() + " - " +
                                    sql_reader.GetString(2).Trim() + Environment.NewLine;

                    }
                    rtxtNGOHist.Text = "Event Date - Event Name - Event Description" + Environment.NewLine + HistEventList;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            String strSQLInsert = "INSERT INTO [NGO] ([OrgName],[DonationtDetail],[RequestStatus],[EventDate],[EventName]) VALUES ('" +
                                    Program.UsrOrgNameApp + "', '" + txtNGONewEventDetail.Text + "', 'Pending', '" + dtNGONewEventDate.Value + "', '" + txtNGONewEventName.Text + "')";



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

        private void btnNGODocs_Click(object sender, EventArgs e)
        {

            folderBrowserDialog1.ShowDialog();
            MessageBox.Show("Your Files will be save to: " + folderBrowserDialog1.SelectedPath);

        }

        private void btnDonationReport_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(("Data Source=ORACLE\\SQLEXPRESS;Initial Catalog=6955_FA2_PRG521;Integrated Security=True"));
                connection.Open();

                SqlCommand DonationReport = new SqlCommand();

                DonationReport = new SqlCommand("SELECT [ID], [OrgName], [DonationtDetail], [RequestStatus], [EventDate], [EventName], [User], [DonationAmmount] FROM[DonorRequest] Where[OrgName] = '" + Program.UsrOrgNameApp + "'Order By [EventDate] Asc", connection);
                SqlDataReader sql_reader;
                sql_reader = DonationReport.ExecuteReader();

                if (sql_reader.HasRows)
                {


                    String EventList = "";
                    while (sql_reader.Read())
                    {
                        EventList = EventList +
                                    sql_reader.GetDateTime(4).ToString() + " - " +
                                    sql_reader.GetString(5).Trim() + " - " +
                                    sql_reader.GetString(3).Trim() + " - " +
                                    sql_reader.GetString(6).Trim() + " - " +
                                    sql_reader.GetValue(7).ToString() + " - " +
                                    sql_reader.GetString(2).Trim() + Environment.NewLine;

                    }
                    rtxtNGODonationReport.Text = "Event Date - Event Name - Event Status - User - Event Description  - DonationAmmount" + Environment.NewLine + EventList;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtNGONewEventName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
