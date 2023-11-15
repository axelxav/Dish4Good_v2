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
    public partial class PenerimaDonasiForm : Form
    {
        private const string connectionString = "Host=localhost;Username=postgres;Password=1234;Database=Dish4Good";
        private DataTable donasiDataTable;
        private DataTable donasiTerpenuhiDataTable;
        private int loggedInUserId;

        public PenerimaDonasiForm(int userId)
        {
            InitializeComponent();

            loggedInUserId = userId;
            // Inisiasi DataTable untuk menampung data donasi
            donasiDataTable = new DataTable();
            //donasiDataTable.Columns.Add("Donasi ID", typeof(int));
            //donasiDataTable.Columns.Add("Penerima Donasi", typeof(string));
            //donasiDataTable.Columns.Add("Jenis Donasi", typeof(string));
            //donasiDataTable.Columns.Add("Pesan", typeof(string));

            // Inisiasi DataTable untuk menampung data donasi yang sudah terpenuhi
            donasiTerpenuhiDataTable = new DataTable();
            //donasiTerpenuhiDataTable.Columns.Add("Donasi ID", typeof(int));
            //donasiTerpenuhiDataTable.Columns.Add("Penerima Donasi", typeof(string));
            //donasiTerpenuhiDataTable.Columns.Add("Jenis Donasi", typeof(string));
            //donasiTerpenuhiDataTable.Columns.Add("Pesan", typeof(string));

            // Tampilkan data pada DataGridView
            RefreshDataGridView();

            // Atur DataGridView properties
            dgvDonasi.AutoGenerateColumns = true;
            dgvDonasi.DataSource = donasiDataTable;

            dgvDonasiTerpenuhi.AutoGenerateColumns = true;
            dgvDonasiTerpenuhi.DataSource = donasiTerpenuhiDataTable;

            UpdateUsernameLabel();
        }

        private void UpdateUsernameLabel()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT username FROM Users WHERE user_id = @userId";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@userId", loggedInUserId);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string username = result.ToString();
                        lblUsername.Text = $"{username}";
                    }
                    else
                    {
                        // Handle jika username tidak ditemukan
                        lblUsername.Text = "Welcome!";
                    }
                }
            }
        }

        //private void RefreshDataGridView()
        //{
        //    // Bersihkan data sebelum memuat data baru
        //    donasiDataTable.Clear();
        //    donasiTerpenuhiDataTable.Clear();
        //
        //    // Dapatkan user id yang sedang login
        //    int userId = GetLoggedInUserId();
        //
        //    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        //    {
        //        connection.Open();
        //
        //        // Ambil data donasi yang belum terpenuhi sesuai dengan user id
        //        string queryDonasi = "SELECT * FROM DonasiRequests WHERE user_id = @user_id AND status = 'belum_terpenuhi'";
        //        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(queryDonasi, connection))
        //        {
        //            adapter.SelectCommand.Parameters.AddWithValue("@user_id", userId);
        //            adapter.Fill(donasiDataTable);
        //        }
        //
        //        // Ambil data donasi yang sudah terpenuhi sesuai dengan user id
        //        string queryDonasiTerpenuhi = "SELECT * FROM DonasiRequests WHERE user_id = @user_id AND status = 'terpenuhi'";
        //        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(queryDonasiTerpenuhi, connection))
        //        {
        //            adapter.SelectCommand.Parameters.AddWithValue("@user_id", userId);
        //            adapter.Fill(donasiTerpenuhiDataTable);
        //        }
        //    }
        //}

        private void RefreshDataGridView()
        {
            // Bersihkan data sebelum memuat data baru
            donasiDataTable.Clear();
            donasiTerpenuhiDataTable.Clear();

            // Dapatkan user id yang sedang login
            int userId = GetLoggedInUserId();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Ambil data donasi yang belum terpenuhi sesuai dengan user id
                string queryDonasi = "SELECT * FROM DonasiRequests WHERE user_id = @user_id AND status = 'belum_terpenuhi'";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(queryDonasi, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@user_id", userId);
                    adapter.Fill(donasiDataTable);
                }

                // Ambil data donasi yang sudah terpenuhi sesuai dengan user id
                string queryDonasiTerpenuhi = "SELECT * FROM DonasiRequests WHERE user_id = @user_id AND status = 'terpenuhi'";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(queryDonasiTerpenuhi, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@user_id", userId);
                    adapter.Fill(donasiTerpenuhiDataTable);
                }
            }
        }



        private int GetLoggedInUserId()
        {
            return loggedInUserId; // Ganti dengan implementasi sesuai kebutuhan
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Show();
            this.Hide();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            // Refresh DataGridView
            RefreshDataGridView();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            // Buka form dialog untuk menambahkan permintaan donasi baru
            FormDonasiBaru tambahDonasiForm = new FormDonasiBaru(loggedInUserId);
            tambahDonasiForm.ShowDialog();

            // Refresh DataGridView setelah menutup form dialog
            RefreshDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Pastikan bahwa baris yang dipilih tidak kosong
            if (dgvDonasi.SelectedRows.Count > 0)
            {
                // Ambil nilai dari kolom request_id pada baris yang dipilih
                int requestIdToDelete = Convert.ToInt32(dgvDonasi.SelectedRows[0].Cells["request_id"].Value);

                // Konfirmasi pengguna sebelum menghapus
                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus permintaan donasi ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Panggil metode untuk menghapus permintaan donasi dari database
                    HapusPermintaanDonasi(requestIdToDelete);

                    // Refresh DataGridView setelah menghapus
                    RefreshDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Pilih permintaan donasi yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HapusPermintaanDonasi(int requestId)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Lakukan penghapusan permintaan donasi berdasarkan request_id
                string query = "DELETE FROM DonasiRequests WHERE request_id = @requestId";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@requestId", requestId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
