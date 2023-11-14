using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Dish4Good_v2
{
    public partial class DonaturForm : Form
    {
        private const string ConnectionString = "Host=localhost;Username=postgres;Password=1234;Database=Dish4Good";
        private int userID; // ID pengguna yang sedang login

        public DonaturForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;

            // Load data permintaan donasi saat form diinisialisasi
            LoadPermintaanDonasi();
        }

        private void LoadPermintaanDonasi()
        {
            // Mengambil data permintaan donasi dari database
            // Implementasi dapat disesuaikan sesuai dengan struktur database Anda
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    // Query untuk mengambil daftar permintaan donasi yang belum didonasikan
                    cmd.CommandText = "SELECT * FROM PermintaanDonasi WHERE Status = 'Pending'";

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewPermintaanDonasi.DataSource = dataTable;
                }
            }
        }

        private void dataGridViewPermintaanDonasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ambil data dari baris yang diklik
            int selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridViewPermintaanDonasi.Rows[selectedRow];

            // Tampilkan deskripsi permintaan donasi pada TextBox
            txtDeskripsiDonasi.Text = row.Cells["Deskripsi"].Value.ToString();
        }

        private void btnKonfirmasiDonasi_Click(object sender, EventArgs e)
        {
            // Ambil data dari form
            int selectedRow = dataGridViewPermintaanDonasi.SelectedCells[0].RowIndex;
            int permintaanID = Convert.ToInt32(dataGridViewPermintaanDonasi.Rows[selectedRow].Cells["PermintaanID"].Value);
            string deskripsiDonasi = txtDeskripsiDonasi.Text;

            // Perbarui data permintaan donasi dengan deskripsi dan status "Donated"
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    // Query untuk memperbarui data permintaan donasi
                    cmd.CommandText = "UPDATE PermintaanDonasi SET DeskripsiDonasi = @deskripsiDonasi, Status = 'Donated' WHERE PermintaanID = @permintaanID";
                    cmd.Parameters.AddWithValue("@deskripsiDonasi", deskripsiDonasi);
                    cmd.Parameters.AddWithValue("@permintaanID", permintaanID);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Donasi berhasil dikonfirmasi!");
                        LoadPermintaanDonasi(); // Refresh data setelah konfirmasi
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengkonfirmasi donasi!");
                    }
                }
            }
        }
    }
}
