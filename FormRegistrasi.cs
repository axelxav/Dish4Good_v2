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

namespace Dish4Good_v2
{
    public partial class FormRegistrasi : Form
    {
        private const string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=Dish4Good";

        public FormRegistrasi()
        {
            InitializeComponent();

            // Inisiasi isi ComboBox untuk role
            cmbRole.Items.Add("Penerima Donasi");
            cmbRole.Items.Add("Donatur");

            // Pilih default role (opsional)
            cmbRole.SelectedIndex = 0;
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string role = cmbRole.Text;

            // Validasi data input (sesuai kebutuhan)

            // Simpan data ke database
            SaveToDatabase(username, password, role);

            MessageBox.Show("Registrasi berhasil!");

            // Setelah registrasi, arahkan ke form login atau form lainnya
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide(); // Sembunyikan form registrasi jika diperlukan
        }

        private void SaveToDatabase(string username, string password, string role)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Users (username, password, role) VALUES (@username, @password, @role)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnLoginPage_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void btnRegis_Click_1(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string role = cmbRole.Text;

            // Validasi data input (sesuai kebutuhan)

            // Simpan data ke database
            SaveToDatabase(username, password, role);

            MessageBox.Show("Registrasi berhasil!");

            // Setelah registrasi, arahkan ke form login atau form lainnya
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide(); // Sembunyikan form registrasi jika diperlukan
        }
    }
}
