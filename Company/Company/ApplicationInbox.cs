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
    public partial class ApplicationInbox : Form
    {
        string name;
        int sentPersonId;
        public ApplicationInbox(string name)
        {
            InitializeComponent();
            this.name = name;
        }
        SqlConnection connection = new SqlConnection("Data Source=Seyrek\\SQLEXPRESS;Initial Catalog=MMS;" +
            "Integrated Security=True");
        String query = "Select DISTINCT i.InboxId, i.MailText, i.SendDate, i.Seen from Person p, Email e, Inbox i Where " +
            "p.PersonId = i.SentPersonId And p.Name = @Name And i.MailId is null";
        DataSet dataset = new DataSet();
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ApplicationInbox_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataset, "Inbox");
            dataGridView1.DataSource = dataset.Tables["Inbox"];
            connection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
