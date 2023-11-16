using Npgsql;

namespace Dish4Good_v2
{
    public partial class Form1 : Form
    {
        private const string connectionString = "Host=localhost;Username=postgres;Password=1816;Database=Dish4Good";
        private int loggedInUserId; // Variabel untuk menyimpan user id yang sedang login

        public int LoggedInUserId
        {
            get { return loggedInUserId; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private string GetRoleFromDatabase(string username, string password)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT role FROM Users WHERE username = @username AND password = @password";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();

                    return result != null ? result.ToString() : null;
                }
            }
        }

        private int GetUserIdFromDatabase(string username, string password)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT user_id FROM Users WHERE username = @username AND password = @password";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();

                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            // Tambahkan kode jika diperlukan
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            // Verifikasi pengguna dari database dan dapatkan rolenya
            loggedInUserId = GetUserIdFromDatabase(username, password);
            string role = GetRoleFromDatabase(username, password);

            if (role == "Penerima Donasi")
            {
                // Arahkan ke form PenerimaDonasi dengan menyertakan loggedInUserId
                PenerimaDonasiForm penerimaDonasiForm = new PenerimaDonasiForm(loggedInUserId);
                penerimaDonasiForm.Show();
                this.Hide(); // Sembunyikan form login jika diperlukan
            }
            else if (role == "Donatur")
            {
                // Arahkan ke form Donatur dengan menyertakan loggedInUserId
                DonaturForm donaturForm = new DonaturForm(loggedInUserId);
                donaturForm.Show();
                this.Hide(); // Sembunyikan form login jika diperlukan
            }
            else
            {
                MessageBox.Show("Login gagal. Periksa kembali username dan password.");
            }
        }

        private void btnRegisPage_Click(object sender, EventArgs e)
        {
            FormRegistrasi registrasi = new FormRegistrasi();
            registrasi.Show();
            this.Hide();
        }
    }
}