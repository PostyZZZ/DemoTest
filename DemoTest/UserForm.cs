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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DemoTest
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string connectionString = "Host = localhost; Port = 5432; Username = postgres; Password = 123; Database = DatabaseTest";
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        INSERT INTO requests (request_number, client_name, destination, documents, tour_type, client_count, status)
                        VALUES (@request_number, @client_name, @destination, @documents, @tour_type, @client_count, @status)";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("request_number", txtNum.Text);
                        cmd.Parameters.AddWithValue("client_name", txtName.Text);
                        cmd.Parameters.AddWithValue("destination", txtPlace.Text);
                        cmd.Parameters.AddWithValue("documents", txtDoc.Text);
                        cmd.Parameters.AddWithValue("tour_type", cmbType.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("client_count", (int)NumClient.Value);
                        cmd.Parameters.AddWithValue("status", cmbStatus.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Request added successfully!");
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
