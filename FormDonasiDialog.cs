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
    public partial class FormDonasiDialog : Form
    {
        private const string connectionString = "Host=suleiman.db.elephantsql.com;Port=5432;Username=hfncgxfq;Password=hyufizdquAbkRTS7YQvkbAESPIIFkfQJ;Database=hfncgxfq;";
        private int requestId;
        private int donaturId;

        public FormDonasiDialog(int requestId, int donaturId)
        {
            InitializeComponent();
            this.requestId = requestId;
            this.donaturId = donaturId;
        }

        private void SimpanDonasi(int requestId, int donaturId, string pesanDonasi)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Masukkan data donasi ke tabel Donations
                string query = "INSERT INTO Donations (request_id, donatur_id, message) VALUES (@requestId, @donaturId, @message)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@requestId", requestId);
                    cmd.Parameters.AddWithValue("@donaturId", donaturId);
                    cmd.Parameters.AddWithValue("@message", pesanDonasi);

                    cmd.ExecuteNonQuery();
                }

                // Update status permintaan donasi menjadi 'terpenuhi'
                string updateStatusQuery = "UPDATE DonasiRequests SET status = 'terpenuhi' WHERE request_id = @requestId";

                using (NpgsqlCommand cmd = new NpgsqlCommand(updateStatusQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@requestId", requestId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string pesanDonasi = tbPesanDonasi.Text;

            if (!string.IsNullOrEmpty(pesanDonasi))
            {
                // Simpan donasi ke database
                SimpanDonasi(requestId, donaturId, pesanDonasi);

                // Set DialogResult menjadi OK untuk memberi tahu form DonaturForm bahwa donasi telah dikonfirmasi
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Isi pesan donasi terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Set DialogResult menjadi Cancel jika pengguna membatalkan donasi
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}