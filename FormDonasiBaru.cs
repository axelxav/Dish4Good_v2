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
    public partial class FormDonasiBaru : Form
    {
        private const string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=Dish4Good";
        private int loggedInUserId;

        public FormDonasiBaru(int usedId)
        {
            InitializeComponent();

            // Inisiasi isi ComboBox untuk jenis donasi
            cmbJenisDonasi.Items.Add("Makanan");
            cmbJenisDonasi.Items.Add("Minuman");

            // Pilih default jenis donasi (opsional)
            cmbJenisDonasi.SelectedIndex = 0;
            loggedInUserId = usedId;
        }

        private void SaveDonasiToDatabase(string jenisDonasi, string pesanDonasi)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Gantilah user_id sesuai dengan cara Anda menyimpan informasi pengguna yang login
                int userId = GetLoggedInUserId();

                string query = "INSERT INTO DonasiRequests (user_id, donation_type, request_message) VALUES (@user_id, @jenisDonasi, @pesanDonasi)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@user_id", userId);
                    cmd.Parameters.AddWithValue("@jenisDonasi", jenisDonasi);
                    cmd.Parameters.AddWithValue("@pesanDonasi", pesanDonasi);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private int GetLoggedInUserId()
        {
            return loggedInUserId; // Ganti dengan implementasi sesuai kebutuhan
        }

        private void btnTambahDonasi_Click_1(object sender, EventArgs e)
        {
            string jenisDonasi = cmbJenisDonasi.Text;
            string pesanDonasi = txtPesanDonasi.Text;

            // Validasi data input (sesuai kebutuhan)

            // Simpan permintaan donasi baru ke database
            SaveDonasiToDatabase(jenisDonasi, pesanDonasi);

            MessageBox.Show("Permintaan donasi berhasil ditambahkan!");

            // Tutup form setelah menambahkan permintaan donasi
            this.Close();
        }
    }
}
