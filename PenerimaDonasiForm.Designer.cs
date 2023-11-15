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
            lblPenerima = new Label();
            lblUsername = new Label();
            lblBrand = new Label();
            pnlKonfirmasi = new Panel();
            dgvDonasiTerpenuhi = new DataGridView();
            lblPermintaanBerhasil = new Label();
            pnlDaftar = new Panel();
            btnLoadData = new Button();
            btnDelete = new Button();
            btnTambah = new Button();
            dgvDonasi = new DataGridView();
            lblDaftarPermintaan = new Label();
            btnLogOut = new Button();
            pnlHeader.SuspendLayout();
            pnlKonfirmasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonasiTerpenuhi).BeginInit();
            pnlDaftar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonasi).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblPenerima);
            pnlHeader.Controls.Add(lblUsername);
            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(871, 62);
            pnlHeader.TabIndex = 0;
            // 
            // lblPenerima
            // 
            lblPenerima.AutoSize = true;
            lblPenerima.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            lblPenerima.Location = new Point(799, 34);
            lblPenerima.Margin = new Padding(2, 0, 2, 0);
            lblPenerima.Name = "lblPenerima";
            lblPenerima.Size = new Size(60, 15);
            lblPenerima.TabIndex = 4;
            lblPenerima.Text = "Penerima";
            lblPenerima.TextAlign = ContentAlignment.TopRight;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(741, 12);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(118, 20);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Nama Pengguna";
            lblUsername.TextAlign = ContentAlignment.TopRight;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblBrand.Location = new Point(20, 12);
            lblBrand.Margin = new Padding(2, 0, 2, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(159, 37);
            lblBrand.TabIndex = 2;
            lblBrand.Text = "Dish4Good";
            // 
            // pnlKonfirmasi
            // 
            pnlKonfirmasi.BackColor = Color.White;
            pnlKonfirmasi.Controls.Add(dgvDonasiTerpenuhi);
            pnlKonfirmasi.Controls.Add(lblPermintaanBerhasil);
            pnlKonfirmasi.Location = new Point(20, 82);
            pnlKonfirmasi.Margin = new Padding(2);
            pnlKonfirmasi.Name = "pnlKonfirmasi";
            pnlKonfirmasi.Size = new Size(305, 456);
            pnlKonfirmasi.TabIndex = 1;
            // 
            // dgvDonasiTerpenuhi
            // 
            dgvDonasiTerpenuhi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonasiTerpenuhi.Location = new Point(17, 62);
            dgvDonasiTerpenuhi.Margin = new Padding(2);
            dgvDonasiTerpenuhi.Name = "dgvDonasiTerpenuhi";
            dgvDonasiTerpenuhi.RowHeadersWidth = 82;
            dgvDonasiTerpenuhi.RowTemplate.Height = 41;
            dgvDonasiTerpenuhi.Size = new Size(270, 376);
            dgvDonasiTerpenuhi.TabIndex = 3;
            // 
            // lblPermintaanBerhasil
            // 
            lblPermintaanBerhasil.AutoSize = true;
            lblPermintaanBerhasil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPermintaanBerhasil.Location = new Point(17, 18);
            lblPermintaanBerhasil.Margin = new Padding(2, 0, 2, 0);
            lblPermintaanBerhasil.Name = "lblPermintaanBerhasil";
            lblPermintaanBerhasil.Size = new Size(202, 28);
            lblPermintaanBerhasil.TabIndex = 2;
            lblPermintaanBerhasil.Text = "Permintaan Berhasil";
            // 
            // pnlDaftar
            // 
            pnlDaftar.BackColor = Color.White;
            pnlDaftar.Controls.Add(btnLoadData);
            pnlDaftar.Controls.Add(btnDelete);
            pnlDaftar.Controls.Add(btnTambah);
            pnlDaftar.Controls.Add(dgvDonasi);
            pnlDaftar.Controls.Add(lblDaftarPermintaan);
            pnlDaftar.Location = new Point(348, 82);
            pnlDaftar.Margin = new Padding(2);
            pnlDaftar.Name = "pnlDaftar";
            pnlDaftar.Size = new Size(500, 500);
            pnlDaftar.TabIndex = 2;
            // 
            // btnLoadData
            // 
            btnLoadData.BackColor = Color.LightSlateGray;
            btnLoadData.FlatAppearance.BorderSize = 0;
            btnLoadData.FlatStyle = FlatStyle.Flat;
            btnLoadData.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadData.ForeColor = Color.White;
            btnLoadData.Location = new Point(316, 452);
            btnLoadData.Margin = new Padding(2);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(160, 31);
            btnLoadData.TabIndex = 6;
            btnLoadData.Text = "Muat Ulang";
            btnLoadData.UseVisualStyleBackColor = false;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.FlatAppearance.BorderColor = Color.Firebrick;
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Firebrick;
            btnDelete.Location = new Point(198, 452);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 31);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Hapus";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.DodgerBlue;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(316, 18);
            btnTambah.Margin = new Padding(2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(160, 28);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // dgvDonasi
            // 
            dgvDonasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonasi.Location = new Point(18, 62);
            dgvDonasi.Margin = new Padding(2);
            dgvDonasi.Name = "dgvDonasi";
            dgvDonasi.RowHeadersWidth = 82;
            dgvDonasi.RowTemplate.Height = 41;
            dgvDonasi.Size = new Size(458, 376);
            dgvDonasi.TabIndex = 1;
            // 
            // lblDaftarPermintaan
            // 
            lblDaftarPermintaan.AutoSize = true;
            lblDaftarPermintaan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDaftarPermintaan.Location = new Point(18, 18);
            lblDaftarPermintaan.Margin = new Padding(2, 0, 2, 0);
            lblDaftarPermintaan.Name = "lblDaftarPermintaan";
            lblDaftarPermintaan.Size = new Size(187, 28);
            lblDaftarPermintaan.TabIndex = 0;
            lblDaftarPermintaan.Text = "Daftar Permintaan";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Firebrick;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(20, 552);
            btnLogOut.Margin = new Padding(2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(305, 31);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Keluar";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click_1;
            // 
            // PenerimaDonasiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(870, 596);
            Controls.Add(btnLogOut);
            Controls.Add(pnlDaftar);
            Controls.Add(pnlKonfirmasi);
            Controls.Add(pnlHeader);
            Margin = new Padding(2);
            Name = "PenerimaDonasiForm";
            Text = "Penerima Donasi";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlKonfirmasi.ResumeLayout(false);
            pnlKonfirmasi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonasiTerpenuhi).EndInit();
            pnlDaftar.ResumeLayout(false);
            pnlDaftar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonasi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblBrand;
        private Panel pnlKonfirmasi;
        private Panel pnlDaftar;
        private DataGridView dgvDonasi;
        private Label lblDaftarPermintaan;
        private Label lblPenerima;
        private Label lblUsername;
        private Label lblPermintaanBerhasil;
        private Button btnTambah;
        private Button btnLogOut;
        private DataGridView dgvDonasiTerpenuhi;
        private Button btnDelete;
        private Button btnLoadData;
    }
}