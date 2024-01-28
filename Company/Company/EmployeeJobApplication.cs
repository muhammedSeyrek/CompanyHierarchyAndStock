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
using static System.Net.Mime.MediaTypeNames;

namespace Company
{
    public partial class EmployeeJobApplication : Form
    {
        public EmployeeJobApplication()
        {
            InitializeComponent();
        }
        int personId;
        String text;
        int mailId = -1;
        SqlConnection connection = new SqlConnection("Data Source=Seyrek\\SQLEXPRESS;Initial Catalog=MMS;" +
            "Integrated Security=True");
        String query = "Select BranchName from Branch";
        private void EmployeeJobApplication_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string pass = reader.GetString("BranchName");
                cmbBranch.Items.Add(pass);
            }
            connection.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            text = txtMessageBox.Text;
            try { 
                string sqlQuery = "INSERT INTO Inbox (MailText, SendDate, Seen, MailId, SentPersonId) " +
                                      "VALUES (@MailText, @SendDate, MailId, 0, @SentPersonId)";
                connection.Open();
                string queryMan = "Select PersonId from Branch Where BranchName = '"+ cmbBranch.Text +"'";
                SqlCommand command2 = new SqlCommand(queryMan, connection);
                SqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    personId = reader2.GetInt32("PersonId");
                }
                connection.Close();
                connection.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@MailText", text);
                command.Parameters.AddWithValue("@SendDate", DateTime.Now);
                command.Parameters.AddWithValue("@SendDate", mailId);
                command.Parameters.AddWithValue("@SentPersonId", personId);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sent Mail.");
                }
                else
                {
                    MessageBox.Show("it's Failed.");
                }
        }
            catch (Exception ex)
            {
                MessageBox.Show("Database Problem: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            this.Hide();
        }
    }
}
