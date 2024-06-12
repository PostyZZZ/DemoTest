using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;

namespace DemoTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_auth_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=DatabaseTest";
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT role FROM users WHERE username=@username AND password=@password";
                    using (var cmd = new NpgsqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("username", textBox_lgn.Text);
                        cmd.Parameters.AddWithValue("password", textBox_pass.Text);

                        var role = cmd.ExecuteScalar() as string;
                        if (role == null)
                        {
                            MessageBox.Show("Invalid username or password.");
                            return;
                        }

                        switch (role)
                        {
                            case "admin":
                                var adminForm = new AdminForm();
                                adminForm.Show();
                                this.Hide();
                                break;
                            case "user":
                                var userForm = new UserForm();
                                userForm.Show();
                                this.Hide();
                                break;
                            default:
                                MessageBox.Show("Unknown role.");
                                break;
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
