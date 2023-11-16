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
        private const string connectionString = "Host=suleiman.db.elephantsql.com;Port=5432;Username=hfncgxfq;Password=hyufizdquAbkRTS7YQvkbAESPIIFkfQJ;Database=hfncgxfq;";
        private DataTable donasiDataTable;
        private DataTable donasiDonaturDataTable;
        private int loggedInUserId;

        public DonaturForm(int userId)
        {
            InitializeComponent();

            loggedInUserId = userId;

            // Inisialisasi DataTable untuk menampung data permintaan donasi dari Penerima Donasi
            donasiDataTable = new DataTable();
            //donasiDataTable.Columns.Add("Request ID", typeof(int));
            //donasiDataTable.Columns.Add("Penerima Donasi", typeof(string));
            //donasiDataTable.Columns.Add("Jenis Donasi", typeof(string));
            //donasiDataTable.Columns.Add("Pesan", typeof(string));

            // Inisialisasi DataTable untuk menampung data donasi yang pernah diakukan oleh Donatur
            donasiDonaturDataTable = new DataTable();
            //donasiDonaturDataTable.Columns.Add("Donasi ID", typeof(int));
            //donasiDonaturDataTable.Columns.Add("Penerima Donasi", typeof(string));
            //donasiDonaturDataTable.Columns.Add("Jenis Donasi", typeof(string));
            //donasiDonaturDataTable.Columns.Add("Pesan", typeof(string));

            // Tampilkan data pada DataGridView
            RefreshDataGridView();

            // Atur DataGridView properties
            dgvPermintaanDonasi.AutoGenerateColumns = true;
            dgvPermintaanDonasi.DataSource = donasiDataTable;

            dgvDonasiDonatur.AutoGenerateColumns = true;
            dgvDonasiDonatur.DataSource = donasiDonaturDataTable;

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
                        lblUsernameDonatur.Text = $"{username}";
                    }
                    else
                    {
                        // Handle jika username tidak ditemukan
                        lblUsernameDonatur.Text = "Welcome!";
                    }
                }
            }
        }

        private void RefreshDataGridView()
        {
            // Bersihkan data sebelum memuat data baru
            donasiDataTable.Clear();
            donasiDonaturDataTable.Clear();

            // Dapatkan data permintaan donasi dari Penerima Donasi
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM DonasiRequests WHERE status = 'belum_terpenuhi'";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                {
                    adapter.Fill(donasiDataTable);
                }
            }

            // Dapatkan data donasi yang pernah dilakukan oleh Donatur
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Donations WHERE donatur_id = @donatur_id";
                using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@donatur_id", loggedInUserId);
                    adapter.Fill(donasiDonaturDataTable);
                }
            }
        }

        private void lblStatusKonfirmasiDonatur_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
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

        private void btnDonasiDonatur_Click_1(object sender, EventArgs e)
        {
            // Pastikan bahwa baris yang dipilih tidak kosong
            if (dgvPermintaanDonasi.SelectedRows.Count > 0)
            {
                // Ambil nilai dari kolom request_id pada baris yang dipilih
                int requestId = Convert.ToInt32(dgvPermintaanDonasi.SelectedRows[0].Cells["request_id"].Value);

                // Buka form dialog untuk memasukkan pesan donasi
                FormDonasiDialog formDonasiDialog = new FormDonasiDialog(requestId, loggedInUserId);
                DialogResult result = formDonasiDialog.ShowDialog();

                // Jika pengguna mengkonfirmasi donasinya, refresh DataGridView
                if (result == DialogResult.OK)
                {
                    RefreshDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Pilih permintaan donasi yang ingin Anda donasi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblUsernameDonatur_Click(object sender, EventArgs e)
        {

        }
    }
}
