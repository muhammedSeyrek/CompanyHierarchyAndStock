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
    public partial class ManagerPanel : Form
    {
        String name;
        public ManagerPanel(String name)
        {
            InitializeComponent();
            this.name = name;
        }
        SqlConnection connection = new SqlConnection("Data Source=Seyrek\\SQLEXPRESS;Initial Catalog=MMS;" +
            "Integrated Security=True");
        DataSet dataSet = new DataSet();
        private void ManagerPanel_Load(object sender, EventArgs e)
        {

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerToSupplier managerToSupplier = new ManagerToSupplier(name);
            managerToSupplier.Show();
        }

        private void ınboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerInbox managerInbox = new ManagerInbox(name);
            managerInbox.Show();
        }

        private void listEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            cmbCollar.Items.Clear();

            connection.Open();

            SqlCommand collarCommand = new SqlCommand("SELECT CollarId, CollarName FROM Collar", connection);
            SqlDataReader collarReader = collarCommand.ExecuteReader();

            Dictionary<int, string> collarDictionary = new Dictionary<int, string>();

            while (collarReader.Read())
            {
                int collarId = collarReader.GetInt32(0);
                string collarName = collarReader.GetString(1);
                collarDictionary.Add(collarId, collarName);

                if (collarName != "Yellow")
                    cmbCollar.Items.Add(collarName);
            }

            collarReader.Close();

            SqlCommand personCommand = new SqlCommand("SELECT * FROM Person WHERE Mgr = (SELECT PersonId FROM Person WHERE Name = @Name)", connection);
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
                        if (reader.GetName(i) == "CollarId" && collarDictionary.ContainsKey(reader.GetInt32(i)))
                        {
                            values[i] = collarDictionary[reader.GetInt32(i)];
                        }
                        else
                        {
                            values[i] = reader.GetValue(i);
                        }
                    }

                    dataGridView1.Rows.Add(values);
                }
            }

            connection.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPersonId.Text = dataGridView1.CurrentRow.Cells["PersonId"].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            txtJob.Text = dataGridView1.CurrentRow.Cells["Job"].Value.ToString();
            txtBirthday.Text = dataGridView1.CurrentRow.Cells["Birthday"].Value.ToString();
            txtSalary.Text = dataGridView1.CurrentRow.Cells["Salary"].Value.ToString();
            txtComm.Text = dataGridView1.CurrentRow.Cells["Comm"].Value.ToString();
            cmbCollar.Text = dataGridView1.CurrentRow.Cells["CollarId"].Value.ToString();
            txtMail.Text = dataGridView1.CurrentRow.Cells["MailId"].Value.ToString();
            txtWorkTime.Text = dataGridView1.CurrentRow.Cells["Work"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int personIdToDelete = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PersonId"].Value);

                connection.Open();

                // Silme işlemi için SQL sorgusu
                string deleteQuery = "DELETE FROM Person WHERE PersonId = @PersonId";

                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@PersonId", personIdToDelete);
                    deleteCommand.ExecuteNonQuery();

                    MessageBox.Show("Record deleted successfully!");
                }

                connection.Close();

                // Veritabanından kaydı sildikten sonra DataGridView'ı güncelleme
                listEmployeeToolStripMenuItem_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a row to delete!");
            }
            clean();
        }

        private void clean()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                    item.Text = "";
                if (item is ComboBox)
                    item.Text = "";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedCollarName = cmbCollar.Text;
                int selectedCollarId;

                connection.Open();

                string findCollarIdQuery = "SELECT CollarId FROM Collar WHERE CollarName = @CollarName";

                using (SqlCommand findCollarIdCommand = new SqlCommand(findCollarIdQuery, connection))
                {
                    findCollarIdCommand.Parameters.AddWithValue("@CollarName", selectedCollarName);
                    selectedCollarId = (int)findCollarIdCommand.ExecuteScalar();
                }

                connection.Close();

                int personIdToUpdate = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["PersonId"].Value);

                connection.Open();

                string updateQuery = @"
                        UPDATE Person SET
                            Name = @Name,
                            Job = @Job,
                            Birthday = @Birthday,
                            Salary = @Salary,
                            Comm = @Comm,
                            CollarId = @CollarId,
                            Work = @Work
                        WHERE PersonId = @PersonId
                    ";

                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@PersonId", personIdToUpdate);
                    updateCommand.Parameters.AddWithValue("@Name", txtName.Text);
                    updateCommand.Parameters.AddWithValue("@Job", txtJob.Text);
                    updateCommand.Parameters.AddWithValue("@Birthday", DateTime.Parse(txtBirthday.Text));
                    updateCommand.Parameters.AddWithValue("@Salary", txtSalary.Text);
                    updateCommand.Parameters.AddWithValue("@Comm", txtComm.Text);
                    updateCommand.Parameters.AddWithValue("@CollarId", selectedCollarId);
                    updateCommand.Parameters.AddWithValue("@Work", txtWorkTime.Text);
                    updateCommand.ExecuteNonQuery();

                    MessageBox.Show("Record updated successfully!");
                }

                connection.Close();

                listEmployeeToolStripMenuItem_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please select a row to update!");
            }
            clean();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(name);
            addEmployee.Show();
        }

        private void sentMailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerToEmployee managerToEmployee = new ManagerToEmployee(name);
            managerToEmployee.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerListProduct managerListProduct = new ManagerListProduct(name);
            managerListProduct.Show();
        }

        private void jobApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplicationInbox applicationInbox = new ApplicationInbox(name);
            applicationInbox.Show();
        }
    }
}
