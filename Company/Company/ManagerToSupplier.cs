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
    public partial class ManagerToSupplier : Form
    {
        string name;
        int mailId;
        public ManagerToSupplier(String name)//Constructor'dan her daim bu tip işlemlerde giris yapan kisinin ismi olacak.
        {
            InitializeComponent();
            this.name = name;
        }

        SqlConnection connection = new SqlConnection("Data Source=Seyrek\\SQLEXPRESS;Initial Catalog=MMS;" +
            "Integrated Security=True");
        String query = "SELECT SupplierName FROM Supplier WHERE BranchId = (SELECT BranchId FROM Branch WHERE PersonId = (SELECT PersonId FROM Person WHERE Name = @Name))";


        private void ManagerToSupplier_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", name);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name2 = reader.GetString("SupplierName");
                cmbBoxSupplierName.Items.Add(name2);
            }
            connection.Close();
            connection.Open();
            SqlCommand command2 = new SqlCommand("Select MailId from Person Where Name = '"+ name +"'", connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                mailId = reader2.GetInt32("MailId");
            }
            connection.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String text = txtSentMail.Text;
            try
            {
                connection.Open();


                string sqlQuery = "INSERT INTO Inbox (MailText, SendDate, Seen, MailId, SupplierName) " +
                                  "VALUES (@MailText, @SendDate, 0, (SELECT MailId FROM Person WHERE MailId = @mailId), @SupplierName)";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@MailText", text);
                command.Parameters.AddWithValue("@SendDate", DateTime.Now);
                command.Parameters.AddWithValue("@MailId", mailId);
                command.Parameters.AddWithValue("@SupplierName", cmbBoxSupplierName.Text);

                // Sorguyu veritabanına gönder
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Veri eklendi.");
                }
                else
                {
                    MessageBox.Show("Veri eklenemedi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
