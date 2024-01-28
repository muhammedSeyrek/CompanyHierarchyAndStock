using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Company
{
    public partial class AddProduct : Form
    {
        string empName;
        int manId;
        int branchId;
        int categoryId;
        public AddProduct(string name)
        {
            InitializeComponent();
            this.empName = name;
        }
        SqlConnection connection = new SqlConnection("Data Source=Seyrek\\SQLEXPRESS;Initial Catalog=MMS;" +
            "Integrated Security=True");
        private void AddProduct_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select CategoryName from Category", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(0);
                cmbCategory.Items.Add(name);
            }
            connection.Close();
            connection.Open();
            SqlCommand command2 = new SqlCommand("Select PersonId from Person Where PersonId = (Select Mgr from Person Where Name = @Name)", connection);
            command2.Parameters.AddWithValue("@Name", empName);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                manId = reader2.GetInt32("PersonId");
            }
            connection.Close();
            connection.Open();
            SqlCommand command3 = new SqlCommand("Select BranchId from Branch Where PersonId = @PersonId", connection);
            command3.Parameters.AddWithValue("@PersonId", manId);
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                branchId = reader3.GetInt32("BranchId");
            }
            connection.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command1 = new SqlCommand("Select CategoryId from Category Where CategoryName = @CategoryName", connection);
            command1.Parameters.AddWithValue("@CategoryName", cmbCategory.Text);
            SqlDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                categoryId = reader1.GetInt32("CategoryId");
            }
            connection.Close();

            connection.Open();
            try
            {
                int count = 1;
                SqlCommand command = new SqlCommand("InsertOrUpdateProductWithPrice", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                command.Parameters.AddWithValue("@CategoryId", categoryId);
                command.Parameters.AddWithValue("@ProductCount", count);
                command.Parameters.AddWithValue("@PurchasePrice", SqlMoney.Parse(txtPurchasePrice.Text));
                command.Parameters.AddWithValue("@BranchId", branchId);
                command.ExecuteNonQuery();
                MessageBox.Show("Product Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            connection.Close();
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                if (item is ComboBox)
                    item.Text = "";
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
