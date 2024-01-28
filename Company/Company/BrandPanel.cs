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
    public partial class BrandPanel : Form
    {
        String name;
        int personId;
        public BrandPanel(string name)
        {
            InitializeComponent();
            this.name = name;
        }
        SqlConnection connection = new SqlConnection("Data Source=Seyrek\\SQLEXPRESS;Initial Catalog=MMS;" +
            "Integrated Security=True");
        DataSet dataSet = new DataSet();
        private void BrandPanel_Load(object sender, EventArgs e)
        {
            lblBrandName.Text = name;
            refresh();
        }

        private void refresh()
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT Name FROM Person WHERE CollarId = 20", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                cmbChooseManager.Items.Add(reader["Name"].ToString());
            }

            connection.Close();
            connection.Open();
            SqlCommand supplierCommand = new SqlCommand("SELECT SupplierName FROM Supplier Where BranchId is null", connection);
            SqlDataReader supplierReader = supplierCommand.ExecuteReader();

            while (supplierReader.Read())
            {
                cmbChooseSupplier.Items.Add(supplierReader["SupplierName"].ToString());
            }

            connection.Close();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ınboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrandInbox brandInbox = new BrandInbox();
            brandInbox.Show();
        }

        private void listEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT DISTINCT * FROM Person WHERE Job != 'Owner'", connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            connection.Close();

        }

        private void listBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT * from Branch", connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            connection.Close();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT * from Supplier", connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            connection.Close();
        }

        private void listProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand("SELECT * from Product", connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            connection.Close();
        }

        private void sentMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrandToManager brandToManager = new BrandToManager(name);
            brandToManager.Show();
        }

        private void netWorthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SqlCommand command = new SqlCommand("Select * from vw_ProductNetWorth", connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void btnAssignment_Click(object sender, EventArgs e)
        {
            string branchName = txtNewBranchName.Text;
            string selectedManager = cmbChooseManager.SelectedItem.ToString();
            string selectedSupplier = cmbChooseSupplier.SelectedItem.ToString();
            string query = "Select PersonId from Person Where Name = '" + cmbChooseManager.Text + "'";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                personId = reader.GetInt32("PersonId");
            }
            connection.Close();
            try
            {
                connection.Open();
                SqlCommand branchInsertCommand = new SqlCommand("INSERT INTO Branch (BranchName, PersonId) VALUES " +
                    "(@BranchName, @PersonId); SELECT SCOPE_IDENTITY();", connection);
                branchInsertCommand.Parameters.AddWithValue("@BranchName", branchName);
                branchInsertCommand.Parameters.AddWithValue("@PersonId", personId);
                int newBranchId = Convert.ToInt32(branchInsertCommand.ExecuteScalar());
                connection.Close();
                connection.Open();
                SqlCommand managerUpdateCommand = new SqlCommand("UPDATE Person SET Job = 'Manager', Mgr = (SELECT PersonId FROM Person WHERE Mgr = 1) " +
                    "Where PersonId = @PersonId", connection);
                managerUpdateCommand.Parameters.AddWithValue("@PersonId", personId);
                int managerPersonId = Convert.ToInt32(managerUpdateCommand.ExecuteScalar());
                connection.Close();
                connection.Open();
                SqlCommand supplierUpdateCommand = new SqlCommand("UPDATE Supplier SET BranchId = @BranchId WHERE SupplierName = @SupplierName", connection);
                supplierUpdateCommand.Parameters.AddWithValue("@BranchId", newBranchId);
                supplierUpdateCommand.Parameters.AddWithValue("@SupplierName", selectedSupplier);
                supplierUpdateCommand.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Assignment completed successfully.");
                txtNewBranchName.Clear();
                cmbChooseManager.Items.Clear();
                cmbChooseSupplier.Items.Clear();
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                connection.Close();
            }
        }

        private void getARaiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetaRaiseForm getaRaise = new GetaRaiseForm();
            getaRaise.Show();
        }
    }
}
