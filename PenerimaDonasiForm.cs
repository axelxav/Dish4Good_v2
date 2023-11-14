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
        private const string ConnectionString = "Host=localhost;Username=postgres;Password=1234;Database=Dish4Good";
        private int userID; // ID pengguna yang sedang login
        public PenerimaDonasiForm(int userID)
        {
            InitializeComponent();
            this.userID = userID;

            // load data permintaan donasi saat form dinitiate
            LoadPermintaanDonasi();
        }

        private void LoadPermintaanDonasi()
        {
            // Mengambil data permintaan donasi dari database berdasarkan userID
            // Implementasi dapat disesuaikan sesuai dengan struktur database Anda
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;

                    // Query untuk mengambil daftar permintaan donasi
                    cmd.CommandText = "SELECT * FROM PermintaanDonasi WHERE PenerimaDonasiID = @userID";
                    cmd.Parameters.AddWithValue("@userID", userID);

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewPermintaanDonasi.DataSource = dataTable;
                }
            }
        }

        private void btnBuatDonasiBaru_Click(object sender, EventArgs e)
        {
            // Buka Form DonasiBaru dan teruskan userID
            FormDonasiBaru formDonasiBaru = new FormDonasiBaru(userID);
            formDonasiBaru.ShowDialog();

            // Refresh data setelah kembali dari FormDonasiBaru
            LoadPermintaanDonasi();
        }
    }
}
