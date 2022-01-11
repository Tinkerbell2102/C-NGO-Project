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
    public partial class AdminProfile : Form
    {
        public AdminProfile()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            
            lblAdminDetails.Text = Program.UsrNameApp + " " + Program.UsrLastNameApp + Environment.NewLine +
                                Program.UsrOrgNameApp + Environment.NewLine +
                                "Contact No: " + Program.UsrContactNoApp + Environment.NewLine +
                                "Email: " + Program.UsrContactMailApp;
           

        }

        private void btnPLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnPClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbAAdmin_Click(object sender, EventArgs e)
        {

        }

        private void tbADonor_Click(object sender, EventArgs e)
        {

        }

        private void tbANGO_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlPMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(("Data Source=ORACLE\\SQLEXPRESS;Initial Catalog=6955_FA2_PRG521;Integrated Security=True"));
                connection.Open();

                SqlCommand admindata = new SqlCommand();

                admindata = new SqlCommand("SELECT [UserID],[Firstname],[Lastname],[Username],[Password],[Email],[ContactNumber],[OrgName],[Profile]  FROM [Users] WHERE [Profile] LIKE 'Admin'", connection);
                SqlDataReader sql_reader;
                sql_reader = admindata.ExecuteReader();

                if (sql_reader.HasRows)
                {


                    String EventList = "";
                    while (sql_reader.Read())
                    {
                        EventList = EventList +
                                    sql_reader.GetString(1).Trim() + " - " +
                                    sql_reader.GetString(2).Trim() + " - " +
                                    sql_reader.GetString(3).Trim() + " - " +
                                    sql_reader.GetString(5).Trim() + " - " +
                                    sql_reader.GetString(6).Trim() + Environment.NewLine;

                    }
                    rtxtUserInfo.Text = "Firstname - Lastname - Username - Email - ContactNumber" + Environment.NewLine + EventList;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnNGOInfo_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(("Data Source=ORACLE\\SQLEXPRESS;Initial Catalog=6955_FA2_PRG521;Integrated Security=True"));
                connection.Open();

                SqlCommand Ngodata = new SqlCommand();

                Ngodata = new SqlCommand("SELECT [UserID],[Firstname],[Lastname],[Username],[Password],[Email],[ContactNumber],[OrgName],[Profile]  FROM [Users] WHERE [Profile] LIKE 'Admin'", connection);
                SqlDataReader sql_reader;
                sql_reader = Ngodata.ExecuteReader();

                if (sql_reader.HasRows)
                {


                    String EventList = "";
                    while (sql_reader.Read())
                    {
                        EventList = EventList +
                                    sql_reader.GetString(1).Trim() + " - " +
                                    sql_reader.GetString(2).Trim() + " - " +
                                    sql_reader.GetString(3).Trim() + " - " +
                                    sql_reader.GetString(5).Trim() + " - " +
                                    sql_reader.GetString(7).Trim() + " - " +
                                    sql_reader.GetString(6).Trim() + Environment.NewLine;

                    }
                    rtxtUserInfo.Text = "Firstname - Lastname - Username - Email - Org. Name - ContactNumber" + Environment.NewLine + EventList;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDonorInfo_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(("Data Source=ORACLE\\SQLEXPRESS;Initial Catalog=6955_FA2_PRG521;Integrated Security=True"));
                connection.Open();

                SqlCommand donordata = new SqlCommand();

                donordata = new SqlCommand("SELECT [UserID],[Firstname],[Lastname],[Username],[Password],[Email],[ContactNumber],[OrgName],[Profile]  FROM [Users] WHERE [Profile] LIKE 'Donor'", connection);
                SqlDataReader sql_reader;
                sql_reader = donordata.ExecuteReader();

                if (sql_reader.HasRows)
                {


                    String EventList = "";
                    while (sql_reader.Read())
                    {
                        EventList = EventList +
                                    sql_reader.GetString(1).Trim() + " - " +
                                    sql_reader.GetString(2).Trim() + " - " +
                                    sql_reader.GetString(3).Trim() + " - " +
                                    sql_reader.GetString(5).Trim() + " - " +
                                    sql_reader.GetString(6).Trim() + Environment.NewLine;

                    }
                    rtxtUserInfo.Text = "Firstname - Lastname - Username - Email - ContactNumber" + Environment.NewLine + EventList;
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNGOLoad_Click(object sender, EventArgs e)
        {


            try
            {


                //------------- Make SQL Connection --------------------
                //--------- NB !! DO NOT CLOSE CONNECTION OR RECORD SETS UNTILL FORM CLOSES ----------------


                SqlConnection connection = new SqlConnection(("Data Source=ORACLE\\SQLEXPRESS;Initial Catalog=6955_FA2_PRG521;Integrated Security=True"));
                connection.Open();


                //------------- Get NGO Event Requests with Pending or Declined status ------------------------
                SqlCommand NGOEventsStatus = new SqlCommand();
                NGOEventsStatus = new SqlCommand("SELECT [ID],[OrgName],[DonationtDetail],[RequestStatus],[EventDate],[EventName] FROM [NGO] Where [RequestStatus] in ('Pending','Declined') and [EventDate] > GETDATE() Order By [OrgName],[EventName] Asc", connection);
                SqlDataReader sql_readerNGO;
                sql_readerNGO = NGOEventsStatus.ExecuteReader();

                if (sql_readerNGO.HasRows)
                {
                    sql_readerNGO.Read();
                    txtNGOEventName.Text = sql_readerNGO.GetString(1).Trim();
                    txtNGOEventDate.Text = sql_readerNGO.GetDateTime(4).ToString();
                    txtNGOEventDetail.Text = sql_readerNGO.GetString(2).Trim();
                    cboNGOStatus.Text = sql_readerNGO.GetString(3).Trim();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnDonorLoad_Click(object sender, EventArgs e)
        {

            try
            {


                //------------- Make SQL Connection --------------------
                //--------- NB !! DO NOT CLOSE CONNECTION OR RECORD SETS UNTILL FORM CLOSES ----------------
                SqlConnection connection = new SqlConnection(("Data Source=ORACLE\\SQLEXPRESS;Initial Catalog=6955_FA2_PRG521;Integrated Security=True"));

                connection.Open();


                //--------------Get Donations with Pending or Declined Status ---------------------------------
                SqlCommand DonerEventsStatus = new SqlCommand();
                DonerEventsStatus = new SqlCommand("SELECT [ID],[OrgName],[DonationtDetail],[RequestStatus],[EventDate],[EventName],[User],[DonationAmmount] FROM [DonorRequest]Where [RequestStatus] in ('Pending','Declined') and [EventDate] > GETDATE() Order By [OrgName],[EventName] Asc", connection);
                SqlDataReader sql_readerDoner;
                sql_readerDoner = DonerEventsStatus.ExecuteReader();

                if (sql_readerDoner.HasRows)
                {
                    sql_readerDoner.Read();
                    txtDonorName.Text = sql_readerDoner.GetString(6).Trim();
                    txtDonorDate.Text = sql_readerDoner.GetDateTime(4).ToString();
                    txtDonorEvent.Text = sql_readerDoner.GetString(5).Trim();
                    txtDonationType.Text = sql_readerDoner.GetString(2).Trim();
                    txtDonationAmm.Text = sql_readerDoner.GetValue(7).ToString();
                    cmbDonorStatus.Text = sql_readerDoner.GetString(3).Trim();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }
    }
}
