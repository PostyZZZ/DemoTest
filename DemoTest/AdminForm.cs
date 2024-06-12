using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoTest
{
    public partial class AdminForm : Form
    {
        
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=DatabaseTest";

        public AdminForm()
        {
            InitializeComponent();
            LoadRequests();

        }

        private void LoadRequests()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM requests";
                    using (var adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        DataTable requestsTable = new DataTable();
                        adapter.Fill(requestsTable);
                        dataGridViewRequests.DataSource = requestsTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btn_succ_Click(object sender, EventArgs e)
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM requests";
                    using (var adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        NpgsqlCommandBuilder commandBuilder = new NpgsqlCommandBuilder(adapter);
                        DataTable changes = ((DataTable)dataGridViewRequests.DataSource).GetChanges();
                        if (changes != null)
                        {
                            adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                            adapter.Update(changes);
                            ((DataTable)dataGridViewRequests.DataSource).AcceptChanges();
                            MessageBox.Show("Changes saved successfully!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
    

