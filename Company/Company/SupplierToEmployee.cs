using Microsoft.Identity.Client;
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
    public partial class SupplierToEmployee : Form
    {
        string supplierName;
        int mailId;
        int sentPersonId;
        int branchId;
        public SupplierToEmployee(string supplierName)
        {
            InitializeComponent();
            this.supplierName = supplierName;
        }
        SqlConnection connection = new SqlConnection("Data Source=Seyrek\\SQLEXPRESS;Initial Catalog=MMS;" +
            "Integrated Security=True");
        int managerId;
        String employeeName;
        private void SupplierToEmployee_Load(object sender, EventArgs e)
        {
            cmbEmployee.Items.Clear();
            String queryBranch = "Select BranchId from Supplier Where SupplierName = '" + supplierName + "'";
            connection.Open();
            SqlCommand command = new SqlCommand(queryBranch, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                branchId = reader.GetInt32("BranchId");
            }
            connection.Close();
            String queryMan = "Select PersonId from Branch Where BranchId = '" + branchId + "'";
            connection.Open();
            SqlCommand command2 = new SqlCommand(queryMan, connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                managerId = reader2.GetInt32("PersonId");
            }
            connection.Close();
            comboSent();
        }

        private void comboSent()
        {
            connection.Open();
            String queryEmp = "Select Name from Person Where Mgr = (Select PersonId from Branch Where BranchId = @BranchId)";
            SqlCommand command2 = new SqlCommand(queryEmp, connection);
            command2.Parameters.AddWithValue("@BranchId", branchId);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                employeeName = reader2.GetString(0);
                cmbEmployee.Items.Add(employeeName);
            }
            connection.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmbManager_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            
            connection.Open();
            SqlCommand command2 = new SqlCommand("Select MailId from Person Where PersonId = '" + managerId + "'", connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                mailId = reader2.GetInt32("MailId");
            }
            connection.Close();
            
            string chooseEmp = cmbEmployee.Text;
            connection.Open();
            SqlCommand command3 = new SqlCommand("Select PersonId from Person Where Name = '" + chooseEmp + "'", connection);
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                sentPersonId = reader3.GetInt32("PersonId");
            }
            connection.Close();

            String text = txtSent.Text;
            try
            {
                connection.Open();
                string sqlQuery = "INSERT INTO Inbox (MailText, SendDate, Seen, MailId, SentPersonId, SupplierName) " +
                                  "VALUES (@MailText, @SendDate, 0, @MailId, @SentPersonId, @SupplierName)";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@MailText", text);
                command.Parameters.AddWithValue("@SendDate", DateTime.Now);
                command.Parameters.AddWithValue("@MailId", mailId);
                command.Parameters.AddWithValue("@SentPersonId", sentPersonId);
                command.Parameters.AddWithValue("@SupplierName", supplierName);
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
            txtSent.Text = "";
        }
    }
}
