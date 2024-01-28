using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Company
{
    public partial class EnterPanel : Form
    {
        int which = 0;
        public EnterPanel()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=Seyrek\\SQLEXPRESS;Initial Catalog=MMS;" +
            "Integrated Security=True");

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (which == 0)
                MessageBox.Show("Please Showing Work");
            else if (which == 1)
            {
                OpenDB();
                if (brandEnter())
                {
                    this.Hide();
                    BrandPanel brandPanel = new BrandPanel(txtPassword.Text);
                    brandPanel.Show();
                }
                else
                    MessageBox.Show("there is no such person");
                CloseDB();
            }
            else if (which == 2)
            {
                OpenDB();
                if (managerEnter())
                {   connection.Open(); 
                    using (SqlCommand updateWorkCounterCommand = new SqlCommand("UpdateWorkCounter", connection))
                    {
                        updateWorkCounterCommand.CommandType = CommandType.StoredProcedure;
                        updateWorkCounterCommand.Parameters.AddWithValue("@PersonName", txtPassword.Text);
                        updateWorkCounterCommand.ExecuteNonQuery();
                    }
                    connection.Close();
                    this.Hide();
                    ManagerPanel managerPanel = new ManagerPanel(txtPassword.Text);
                    managerPanel.Show();
                }
                else
                    MessageBox.Show("there is no such person");
                CloseDB();
            }
            else if (which == 3)
            {
                OpenDB();
                if (employeeEnter())
                {
                    connection.Open();
                    using (SqlCommand updateWorkCounterCommand = new SqlCommand("UpdateWorkCounter", connection))
                    {
                        updateWorkCounterCommand.CommandType = CommandType.StoredProcedure;
                        updateWorkCounterCommand.Parameters.AddWithValue("@PersonName", txtPassword.Text);
                        updateWorkCounterCommand.ExecuteNonQuery();
                    }
                    connection.Close();
                    this.Hide();
                    EmployeePanel employeePanel = new EmployeePanel(txtPassword.Text);
                    employeePanel.Show();
                }
                else
                    MessageBox.Show("there is no such person");
                CloseDB();
            }
            else if (which == 4)
            {
                OpenDB();
                if (supplierEnter())
                {
                    this.Hide();
                    SupplierPanel supplierPanel = new SupplierPanel(txtPassword.Text);
                    supplierPanel.Show();
                }
                else
                    MessageBox.Show("there is no such person");
                CloseDB();
            }
        }

        private void OpenDB()
        {
            connection.Open();
        }
        private void CloseDB()
        {
            connection.Close();
        }
        private bool brandEnter()
        {
            try
            {
                String queryEmployee = "Select BrandName from Brand";
                SqlCommand command = new SqlCommand(queryEmployee, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    String pass = reader.GetString("BrandName");
                    if (pass == txtPassword.Text)
                    {
                        CloseDB();
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        private bool managerEnter()
        {
            try
            {
                String queryEmployee = "Select Name from Person Where Job = 'Manager'";
                SqlCommand command = new SqlCommand(queryEmployee, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string pass = reader.GetString("Name");
                    if (pass == txtPassword.Text)
                    {
                        CloseDB();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        private bool employeeEnter()
        {
            try
            {
                String queryEmployee = "Select Name from Person Where Job != 'Manager'";
                SqlCommand command = new SqlCommand(queryEmployee, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader.GetString("Name");
                    if (name == txtPassword.Text)
                    {
                        CloseDB();
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        private bool supplierEnter()
        {
            try
            {
                String querySupplier = "Select SupplierName from Supplier";
                SqlCommand command = new SqlCommand(querySupplier, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader.GetString("SupplierName");
                    if (name == txtPassword.Text)
                    {
                        CloseDB();
                        return true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }


        private void EnterPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnEnterSupplier_Click(object sender, EventArgs e)
        {


        }



        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeJobApplication employeeJobApplication = new EmployeeJobApplication();
            employeeJobApplication.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void brandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            which = 1;
        }
        private void managerLogInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            which = 2;
        }

        private void employeeLogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            which = 3;
        }

        private void supplierLogInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            which = 4;
        }
    }
}