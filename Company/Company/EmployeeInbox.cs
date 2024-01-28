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

namespace Company
{
    public partial class EmployeeInbox : Form
    {
        string name;
        public EmployeeInbox(string name)
        {
            InitializeComponent();
            this.name = name;
        }
        SqlConnection connection = new SqlConnection("Data Source=Seyrek\\SQLEXPRESS;Initial Catalog=MMS;" +
            "Integrated Security=True");
        String query = "Select i.InboxId, p.PersonId, p.Name, e.Mail, i.MailText, i.Seen from Person p, Email e, Inbox i Where " +
            "p.PersonId = i.SentPersonId And e.MailId = i.MailId " +
                "And p.Name = @Name";
        DataSet dataSet = new DataSet();
        private void EmployeeInbox_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataSet, "Inbox");
            dataGridView1.DataSource = dataSet.Tables["Inbox"];
            connection.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                connection.Open();
                int columnIndex = dataGridView1.Columns["Seen"].Index;
                int inboxIdIndex = dataGridView1.Columns["InboxId"].Index;
                if (e.ColumnIndex == columnIndex && e.RowIndex >= 0)
                {
                    int inboxId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[inboxIdIndex].Value);
                    int bit = 1;
                    string updateQuery = $"UPDATE Inbox SET Seen = @bit WHERE InboxId = @InboxId";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@bit", bit);
                        command.Parameters.AddWithValue("@InboxId", inboxId);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Mail Seen");
                        }
                        else
                        {
                            MessageBox.Show("Nothing Data.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Update problem: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
