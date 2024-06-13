using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DemoTest
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            var Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string connectionString = "Host = localhost; Port = 5432; Username = postgres; Password = 123; Database = DatabaseTest";
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                        INSERT INTO users (username, password, role)
                        VALUES (@username, @password, @role)";

                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("username", txt_reglog.Text);
                        cmd.Parameters.AddWithValue("password", txt_regpass.Text);
                        cmd.Parameters.AddWithValue("role", cmb_roles.Text);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Регистрация успешна!");
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



