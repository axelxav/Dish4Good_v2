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
        private const string ConnectionString = "Host=localhost;Username=postgres;Password=1234;Database=Dish4Good";
        private int userID;

        public FormDonasiBaru(int userID)
        {
            InitializeComponent();
            this.userID = userID;

            // Inisialisasi combobox dengan jenis-jenis donasi yang mungkin
            cmbJenisDonasi.Items.Add("Makanan");
            cmbJenisDonasi.Items.Add("Minuman");
            cmbJenisDonasi.SelectedIndex = 0; // Pilih item pertama sebagai default
        }

        private void btnBuatDonasi_Click(object sender, EventArgs e)
        {
            // Ambil data dari form
            string jenisDonasi = cmbJenisDonasi.SelectedItem.ToString();
            string deskripsi = txtDeskripsi.Text;

            // Validasi data (sesuai kebutuhan)

            // Simpan permintaan donasi ke database
            if (BuatPermintaanDonasi(jenisDonasi, deskripsi))
            {
                MessageBox.Show("Permintaan donasi berhasil dibuat!");
                this.Close(); // Menutup form setelah permintaan donasi dibuat
            }
            else
            {
                MessageBox.Show("Gagal membuat permintaan donasi!");
            }
        }

        private bool BuatPermintaanDonasi(string jenisDonasi, string deskripsi)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;

                        // Query untuk menyimpan permintaan donasi ke database
                        cmd.CommandText = "INSERT INTO PermintaanDonasi (PenerimaDonasiID, JenisDonasi, Status, TanggalPermintaan, Deskripsi) VALUES (@userID, @jenisDonasi, 'Pending', CURRENT_DATE, @deskripsi)";

                        cmd.Parameters.AddWithValue("@userID", userID);
                        cmd.Parameters.AddWithValue("@jenisDonasi", jenisDonasi);
                        cmd.Parameters.AddWithValue("@deskripsi", deskripsi);

                        int result = cmd.ExecuteNonQuery();

                        return result > 0; // Jika berhasil menyimpan, result akan lebih besar dari 0
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}");
                return false;
            }
        }
    }
}
