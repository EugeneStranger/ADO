using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Liubrary3
{
    public partial class MainForm : Form
    {
        string connectionString;
        SqlConnection connection;
        SqlDataReader reader;
        DataTable table;

        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            MessageBox.Show(
                this, 
                connection.ConnectionString, 
                "ConnectionString", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            richTextBoxQuery.SelectAll();
            richTextBoxQuery.SelectionAlignment = HorizontalAlignment.Center;
            LoadTablesToComboBox();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            string cmdLine = richTextBoxQuery.Text;
            SqlCommand cmd = new SqlCommand(cmdLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            table = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
            while (reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i< reader.FieldCount;i++) row[i] = reader[i];
                table.Rows.Add(row);
            }
            dataGridView.DataSource = table;
            connection.Close();
        }
        public void LoadTablesToComboBox()
        {
            string commandLine = $@"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'";
            SqlCommand cmd = new SqlCommand(commandLine, connection);
            connection.Open();
            reader = cmd.ExecuteReader();
            table = new DataTable();
            for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
            while (reader.Read())
            {
                cbTables.Items.Add(reader[0]);
            }
            reader.Close();
            connection.Close();
         }
    }
}
