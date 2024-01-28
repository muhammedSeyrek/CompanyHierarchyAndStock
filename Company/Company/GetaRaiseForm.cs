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
    public partial class GetaRaiseForm : Form
    {
        public GetaRaiseForm()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=Seyrek\\SQLEXPRESS;Initial Catalog=MMS;" +
            "Integrated Security=True");
        string query = "Select * from Person";
        DataSet dataSet = new DataSet();
        DataTable dataTable = new DataTable();
        private void GetaRaiseForm_Load(object sender, EventArgs e)
        {
            refreshDataGrid();
        }

        private void refreshDataGrid()
        {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connection.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRaise_Click(object sender, EventArgs e)
        {
            connection.Open();

            if(txtRaise.Text != "")
            {
                using (SqlCommand command = new SqlCommand("GetARaise", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@altSinirMiktar", Convert.ToDecimal(txtRaise.Text));

                    command.ExecuteNonQuery();
                }
                connection.Close();
                txtRaise.Clear();
                dataTable.Clear();
                refreshDataGrid();
            }
        }
    }
}
