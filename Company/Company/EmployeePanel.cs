using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Company
{
    public partial class EmployeePanel : Form
    {
        String name;
        int categoryId;
        int branchId;
        int productCount = 1;
        int productId;
        public EmployeePanel(string name)
        {
            InitializeComponent();
            this.name = name;
        }

        SqlConnection connection = new SqlConnection("Data Source=Seyrek\\SQLEXPRESS;Initial Catalog=MMS;" +
            "Integrated Security=True");
        String query = "Select i.InboxId, p.PersonId, p.Name, e.Mail, i.MailText, i.Seen from Person p, Email e, Inbox i Where " +
            "p.PersonId = i.SentPersonId And e.MailId = i.MailId " +
                "And p.Name = @Name";

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void listProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            try
            {
                connection.Open(); // Open the connection before using it

                SqlCommand categoryCommand = new SqlCommand("SELECT CategoryId, CategoryName FROM Category", connection);
                SqlDataReader categoryReader = categoryCommand.ExecuteReader();

                Dictionary<int, string> categoryDictionary = new Dictionary<int, string>();

                while (categoryReader.Read())
                {
                    int categoryId = categoryReader.GetInt32(0);
                    string categoryName = categoryReader.GetString(1);
                    categoryDictionary.Add(categoryId, categoryName);
                }
                categoryReader.Close();

                SqlCommand personCommand = new SqlCommand("Select * from Product, Price pr Where pr.PriceId = Product.PriceId and BranchId = " +
                    "(Select BranchId from Branch Where PersonId = " +
                    "(Select PersonId from Person Where PersonId = " +
                    "(Select Mgr from Person Where Name = @Name)))", connection);
                personCommand.Parameters.AddWithValue("@Name", name);
                SqlDataReader reader = personCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataGridView1.Columns.Add(reader.GetName(i), reader.GetName(i));
                    }

                    while (reader.Read())
                    {
                        object[] values = new object[reader.FieldCount];

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (reader.GetName(i) == "CategoryId" && categoryDictionary.ContainsKey(reader.GetInt32(i)))
                            {
                                values[i] = categoryDictionary[reader.GetInt32(i)];
                            }
                            else
                            {
                                values[i] = reader.GetValue(i);
                            }
                        }

                        dataGridView1.Rows.Add(values);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close(); 
            }
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                if (item is ComboBox)
                    item.Text = "";
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeInbox employeeInbox = new EmployeeInbox(name);
            employeeInbox.Show();
        }

        private void btnSentMail_Click(object sender, EventArgs e)
        {
            //mgr yapısında bulundugu manager istek atilacak.
        }

        private void sentMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeToManager employeeToManager = new EmployeeToManager(name);
            employeeToManager.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(name);
            addProduct.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                connection.Open();

                SqlCommand categoryCommand = new SqlCommand("SELECT CategoryId, CategoryName FROM Category", connection);
                SqlDataReader categoryReader = categoryCommand.ExecuteReader();

                DataTable categoryTable = new DataTable();
                categoryTable.Load(categoryReader);

                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryId";
                cmbCategory.DataSource = categoryTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            txtProductName.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
            cmbCategory.Text = dataGridView1.CurrentRow.Cells["CategoryId"].Value.ToString();
            txtPurchasePrice.Text = dataGridView1.CurrentRow.Cells["PurchasePrice"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand categoryCommand = new SqlCommand("Select CategoryId from Category Where CategoryName = @CategoryName", connection);
            categoryCommand.Parameters.AddWithValue("CategoryName", cmbCategory.Text);
            SqlDataReader categoryReader = categoryCommand.ExecuteReader();
            while (categoryReader.Read()) 
            {
                categoryId = categoryReader.GetInt32("CategoryId");
            }
            connection.Close();
            connection.Open();
            SqlCommand branchCommand = new SqlCommand("Select BranchId from Branch Where PersonId = " +
                "(Select Mgr from Person Where Name = @PersonName)", connection);
            branchCommand.Parameters.AddWithValue("@PersonName", name);
            SqlDataReader branchReader = branchCommand.ExecuteReader();
            while (branchReader.Read())
            {
                branchId = branchReader.GetInt32("BranchId");
            }
            connection.Close();
            connection.Open();
            SqlCommand productCommand = new SqlCommand("Select ProductId from Product Where ProductName = @ProductName", connection);
            productCommand.Parameters.AddWithValue("@ProductName", txtProductName.Text);
            SqlDataReader productReader = productCommand.ExecuteReader();
            while (productReader.Read())
            {
                productId = productReader.GetInt32("ProductId");
            }
            connection.Close();
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("UpdateProduct", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                command.Parameters.AddWithValue("@CategoryId", categoryId);
                command.Parameters.AddWithValue("@ProductCount", productCount);
                command.Parameters.AddWithValue("@PurchasePrice", SqlMoney.Parse(txtPurchasePrice.Text));
                command.Parameters.AddWithValue("@BranchId", branchId);
                command.ExecuteNonQuery();

                MessageBox.Show("Operation completed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand branchCommand = new SqlCommand("Select BranchId from Branch Where PersonId = " +
                "(Select Mgr from Person Where Name = @PersonName)", connection);
            branchCommand.Parameters.AddWithValue("@PersonName", name);
            SqlDataReader branchReader = branchCommand.ExecuteReader();
            while (branchReader.Read())
            {
                branchId = branchReader.GetInt32("BranchId");
            }
            connection.Close();
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("DeleteOrDecreaseProduct", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                command.Parameters.AddWithValue("@BranchId", branchId);
                command.ExecuteNonQuery();

                MessageBox.Show("Operation completed successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
