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
    public partial class ManagerListProduct : Form
    {
        String name;
        public ManagerListProduct(string name)
        {
            InitializeComponent();
            this.name = name;
        }
        SqlConnection connection = new SqlConnection("Data Source=Seyrek\\SQLEXPRESS;Initial Catalog=MMS;" +
            "Integrated Security=True");
        DataSet dataSet = new DataSet();
        private void ManagerListProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Product Where BranchId = " +
                "(Select BranchId from Branch Where PersonId = " +
                "(Select PersonId from Person Where Name = '"+ name +"'))", connection);
            adapter.Fill(dataSet, "Product");
            dataGridView1.DataSource = dataSet.Tables["Product"];
            connection.Close();
        }
    }
}
