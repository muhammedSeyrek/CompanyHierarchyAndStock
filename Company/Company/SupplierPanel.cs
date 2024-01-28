using System;
using System.Collections;
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
    public partial class SupplierPanel : Form
    {
        string name;
        public SupplierPanel(string name)
        {
            InitializeComponent();
            this.name = name;
        }
        SqlConnection connection = new SqlConnection("Data Source=Seyrek\\SQLEXPRESS;Initial Catalog=MMS;" +
            "Integrated Security=True");
        String query = "Select i.InboxId, p.Name, i.MailText, i.Seen from Inbox i, Person p Where i.SentPersonId is null And i.SupplierName = @Name And i.MailId = p.MailId";
        DataSet dataSet = new DataSet();
        private void SupplierPanel_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataSet, "Inbox");
            dataGridView1.DataSource = dataSet.Tables["Inbox"];
            connection.Close();
        }
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ınboxToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sentMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierToEmployee supplierToEmployee = new SupplierToEmployee(name);
            supplierToEmployee.Show();
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
