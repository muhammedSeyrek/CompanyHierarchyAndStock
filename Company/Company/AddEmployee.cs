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
    public partial class AddEmployee : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=Seyrek\\SQLEXPRESS;Initial Catalog=MMS;" +
            "Integrated Security=True");
        string managerName;
        int managerId;
        int collarIdForInt;
        public AddEmployee(string managerName)
        {
            this.managerName = managerName;
            InitializeComponent();
            String queryEmp = "Select * from Collar Where CollarName != 'Yellow'";
            connection.Open();
            SqlCommand command = new SqlCommand(queryEmp, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(1);
                cmbCollar.Items.Add(name);
            }
            connection.Close();
            this.managerName = managerName;
            using (SqlConnection connection = new SqlConnection("Data Source=Seyrek\\SQLEXPRESS;Initial Catalog=MMS;" +
            "Integrated Security=True"))
            {
                connection.Open();
                string queryMan = "SELECT PersonId FROM Person WHERE Name = @ManagerName";
                SqlCommand command2 = new SqlCommand(queryMan, connection);
                command2.Parameters.AddWithValue("@ManagerName", managerName);
                SqlDataReader reader2 = command2.ExecuteReader();

                if (reader2.Read())
                {
                    managerId = reader2.GetInt32(0);
                }
                else
                {
                    MessageBox.Show("Manager not found.");
                    return;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (cmbCollar.Text == "Blue")
                collarIdForInt = 30;
            else if (cmbCollar.Text == "White")
                collarIdForInt = 20;
            try
            {
                Random random = new Random();
                int randomNumber = random.Next(1000, 10000);
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into Person(PersonId, Name, Job, Mgr, Birthday, Salary, CollarId, Gender) " +
                    "Values('" + randomNumber + "', @Name, @Job, @Mgr, @Birthday, @Salary, @CollarId, @Gender)", connection);
                command.Parameters.AddWithValue("@Name", txtName.Text);
                command.Parameters.AddWithValue("@Job", txtJob.Text);
                command.Parameters.AddWithValue("@Mgr", managerId);
                command.Parameters.AddWithValue("@Birthday", Convert.ToDateTime(txtBirthday.Text));
                command.Parameters.AddWithValue("@Salary", Convert.ToDouble(txtSalary.Text));
                command.Parameters.AddWithValue("@CollarId", collarIdForInt);
                command.Parameters.AddWithValue("@Gender", cmbGender.Text);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Employee Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
