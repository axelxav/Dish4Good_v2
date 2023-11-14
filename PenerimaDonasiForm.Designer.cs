namespace Dish4Good_v2
{
    partial class PenerimaDonasiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            pnlKonfirmasi = new Panel();
            pnlDaftar = new Panel();
            lblDaftarPermintaan = new Label();
            dataGridViewPermintaanDonasi = new DataGridView();
            lblBrand = new Label();
            lblUsername = new Label();
            lblPenerima = new Label();
            btnLogOut = new Button();
            lblPermintaanBerhasil = new Label();
            btnTambah = new Button();
            dataGridViewPermintaanBerhasil = new DataGridView();
            btnDelete = new Button();
            btnLoadData = new Button();
            pnlHeader.SuspendLayout();
            pnlKonfirmasi.SuspendLayout();
            pnlDaftar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPermintaanDonasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPermintaanBerhasil).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblPenerima);
            pnlHeader.Controls.Add(lblUsername);
            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1416, 100);
            pnlHeader.TabIndex = 0;
            // 
            // pnlKonfirmasi
            // 
            pnlKonfirmasi.BackColor = Color.White;
            pnlKonfirmasi.Controls.Add(dataGridViewPermintaanBerhasil);
            pnlKonfirmasi.Controls.Add(lblPermintaanBerhasil);
            pnlKonfirmasi.Location = new Point(32, 132);
            pnlKonfirmasi.Name = "pnlKonfirmasi";
            pnlKonfirmasi.Size = new Size(496, 729);
            pnlKonfirmasi.TabIndex = 1;
            // 
            // pnlDaftar
            // 
            pnlDaftar.BackColor = Color.White;
            pnlDaftar.Controls.Add(btnLoadData);
            pnlDaftar.Controls.Add(btnDelete);
            pnlDaftar.Controls.Add(btnTambah);
            pnlDaftar.Controls.Add(dataGridViewPermintaanDonasi);
            pnlDaftar.Controls.Add(lblDaftarPermintaan);
            pnlDaftar.Location = new Point(566, 132);
            pnlDaftar.Name = "pnlDaftar";
            pnlDaftar.Size = new Size(812, 800);
            pnlDaftar.TabIndex = 2;
            // 
            // lblDaftarPermintaan
            // 
            lblDaftarPermintaan.AutoSize = true;
            lblDaftarPermintaan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDaftarPermintaan.Location = new Point(29, 28);
            lblDaftarPermintaan.Name = "lblDaftarPermintaan";
            lblDaftarPermintaan.Size = new Size(296, 45);
            lblDaftarPermintaan.TabIndex = 0;
            lblDaftarPermintaan.Text = "Daftar Permintaan";
            // 
            // dataGridViewPermintaanDonasi
            // 
            dataGridViewPermintaanDonasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPermintaanDonasi.Location = new Point(29, 99);
            dataGridViewPermintaanDonasi.Name = "dataGridViewPermintaanDonasi";
            dataGridViewPermintaanDonasi.RowHeadersWidth = 82;
            dataGridViewPermintaanDonasi.RowTemplate.Height = 41;
            dataGridViewPermintaanDonasi.Size = new Size(744, 602);
            dataGridViewPermintaanDonasi.TabIndex = 1;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblBrand.Location = new Point(32, 19);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(249, 59);
            lblBrand.TabIndex = 2;
            lblBrand.Text = "Dish4Good";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(1187, 22);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(191, 32);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Nama Pengguna";
            lblUsername.TextAlign = ContentAlignment.TopRight;
            // 
            // lblPenerima
            // 
            lblPenerima.AutoSize = true;
            lblPenerima.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            lblPenerima.Location = new Point(1283, 57);
            lblPenerima.Name = "lblPenerima";
            lblPenerima.Size = new Size(95, 25);
            lblPenerima.TabIndex = 4;
            lblPenerima.Text = "Penerima";
            lblPenerima.TextAlign = ContentAlignment.TopRight;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Firebrick;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(32, 883);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(496, 49);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Keluar";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // lblPermintaanBerhasil
            // 
            lblPermintaanBerhasil.AutoSize = true;
            lblPermintaanBerhasil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPermintaanBerhasil.Location = new Point(28, 28);
            lblPermintaanBerhasil.Name = "lblPermintaanBerhasil";
            lblPermintaanBerhasil.Size = new Size(319, 45);
            lblPermintaanBerhasil.TabIndex = 2;
            lblPermintaanBerhasil.Text = "Permintaan Berhasil";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.DodgerBlue;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(513, 28);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(260, 45);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            // 
            // dataGridViewPermintaanBerhasil
            // 
            dataGridViewPermintaanBerhasil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPermintaanBerhasil.Location = new Point(28, 99);
            dataGridViewPermintaanBerhasil.Name = "dataGridViewPermintaanBerhasil";
            dataGridViewPermintaanBerhasil.RowHeadersWidth = 82;
            dataGridViewPermintaanBerhasil.RowTemplate.Height = 41;
            dataGridViewPermintaanBerhasil.Size = new Size(439, 602);
            dataGridViewPermintaanBerhasil.TabIndex = 3;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.FlatAppearance.BorderColor = Color.Firebrick;
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Firebrick;
            btnDelete.Location = new Point(322, 724);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(162, 49);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Hapus";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnLoadData
            // 
            btnLoadData.BackColor = Color.LightSlateGray;
            btnLoadData.FlatAppearance.BorderSize = 0;
            btnLoadData.FlatStyle = FlatStyle.Flat;
            btnLoadData.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadData.ForeColor = Color.White;
            btnLoadData.Location = new Point(513, 724);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(260, 49);
            btnLoadData.TabIndex = 6;
            btnLoadData.Text = "Muat Ulang";
            btnLoadData.UseVisualStyleBackColor = false;
            // 
            // PenerimaDonasiForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1414, 953);
            Controls.Add(btnLogOut);
            Controls.Add(pnlDaftar);
            Controls.Add(pnlKonfirmasi);
            Controls.Add(pnlHeader);
            Name = "PenerimaDonasiForm";
            Text = "Penerima Donasi";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlKonfirmasi.ResumeLayout(false);
            pnlKonfirmasi.PerformLayout();
            pnlDaftar.ResumeLayout(false);
            pnlDaftar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPermintaanDonasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPermintaanBerhasil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblBrand;
        private Panel pnlKonfirmasi;
        private Panel pnlDaftar;
        private DataGridView dataGridViewPermintaanDonasi;
        private Label lblDaftarPermintaan;
        private Label lblPenerima;
        private Label lblUsername;
        private Label lblPermintaanBerhasil;
        private Button btnTambah;
        private Button btnLogOut;
        private DataGridView dataGridViewPermintaanBerhasil;
        private Button btnDelete;
        private Button btnLoadData;
    }
}