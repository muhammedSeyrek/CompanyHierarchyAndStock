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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Company
{
    public partial class ManagerToEmployee : Form
    {
        string name;
        string mailSentName;
        int mailId;
        int sentPersonId;
        string chooseEmp;
        public ManagerToEmployee(string name)
        {
            InitializeComponent();
            this.mailSentName = name;
        }
        SqlConnection connection = new SqlConnection("Data Source=Seyrek\\SQLEXPRESS;Initial Catalog=MMS;" +
            "Integrated Security=True");
        string query = "Select Name from Person Where Mgr = (Select PersonId from Person Where Name = @Name)";
        private void ManagerToEmployee_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", mailSentName);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                name = reader.GetString("Name");
                cmbEmployeeName.Items.Add(name);
            }
            connection.Close();
            connection.Open();
            SqlCommand command2 = new SqlCommand("Select MailId from Person Where Name = '" + mailSentName + "'", connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                mailId = reader2.GetInt32("MailId");
            }
            connection.Close();
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            chooseEmp = cmbEmployeeName.Text;
            connection.Open();
            SqlCommand command3 = new SqlCommand("Select PersonId from Person Where Name = '" + chooseEmp + "'", connection);
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                sentPersonId = reader3.GetInt32("PersonId");
            }
            connection.Close();
            String text = txtSentMail.Text;
            try
            {
                connection.Open();
                string sqlQuery = "INSERT INTO Inbox (MailText, SendDate, Seen, MailId, SentPersonId) " +
                                  "VALUES (@MailText, @SendDate, 0, @MailId, @SentPersonId)";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@MailText", text);
                command.Parameters.AddWithValue("@SendDate", DateTime.Now);
                command.Parameters.AddWithValue("@MailId", mailId);
                command.Parameters.AddWithValue("@SentPersonId", sentPersonId);
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
        }
    }
}
