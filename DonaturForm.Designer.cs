namespace Dish4Good_v2
{
    partial class DonaturForm
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
            lblDonatur = new Label();
            lblUsernameDonatur = new Label();
            lblBrand = new Label();
            pnlRiwayat = new Panel();
            dgvDonasiDonatur = new DataGridView();
            lblStatusKonfirmasiDonatur = new Label();
            pnlDaftar = new Panel();
            btnLoadData = new Button();
            dgvPermintaanDonasi = new DataGridView();
            lblDaftarPermintaan = new Label();
            btnLogOut = new Button();
            btnDonasiDonatur = new Button();
            pnlHeader.SuspendLayout();
            pnlRiwayat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonasiDonatur).BeginInit();
            pnlDaftar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPermintaanDonasi).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblDonatur);
            pnlHeader.Controls.Add(lblUsernameDonatur);
            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(871, 62);
            pnlHeader.TabIndex = 1;
            // 
            // lblDonatur
            // 
            lblDonatur.AutoSize = true;
            lblDonatur.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonatur.Location = new Point(790, 36);
            lblDonatur.Margin = new Padding(2, 0, 2, 0);
            lblDonatur.Name = "lblDonatur";
            lblDonatur.Size = new Size(53, 15);
            lblDonatur.TabIndex = 4;
            lblDonatur.Text = "Donatur";
            lblDonatur.TextAlign = ContentAlignment.TopRight;
            // 
            // lblUsernameDonatur
            // 
            lblUsernameDonatur.AutoSize = true;
            lblUsernameDonatur.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsernameDonatur.Location = new Point(730, 14);
            lblUsernameDonatur.Margin = new Padding(2, 0, 2, 0);
            lblUsernameDonatur.Name = "lblUsernameDonatur";
            lblUsernameDonatur.Size = new Size(118, 20);
            lblUsernameDonatur.TabIndex = 3;
            lblUsernameDonatur.Text = "Nama Pengguna";
            lblUsernameDonatur.TextAlign = ContentAlignment.TopRight;
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
            // pnlRiwayat
            // 
            pnlRiwayat.BackColor = Color.White;
            pnlRiwayat.Controls.Add(dgvDonasiDonatur);
            pnlRiwayat.Controls.Add(lblStatusKonfirmasiDonatur);
            pnlRiwayat.Location = new Point(20, 82);
            pnlRiwayat.Margin = new Padding(2);
            pnlRiwayat.Name = "pnlRiwayat";
            pnlRiwayat.Size = new Size(305, 456);
            pnlRiwayat.TabIndex = 2;
            // 
            // dgvDonasiDonatur
            // 
            dgvDonasiDonatur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonasiDonatur.Location = new Point(17, 62);
            dgvDonasiDonatur.Margin = new Padding(2);
            dgvDonasiDonatur.Name = "dgvDonasiDonatur";
            dgvDonasiDonatur.RowHeadersWidth = 82;
            dgvDonasiDonatur.RowTemplate.Height = 41;
            dgvDonasiDonatur.Size = new Size(270, 376);
            dgvDonasiDonatur.TabIndex = 3;
            // 
            // lblStatusKonfirmasiDonatur
            // 
            lblStatusKonfirmasiDonatur.AutoSize = true;
            lblStatusKonfirmasiDonatur.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatusKonfirmasiDonatur.Location = new Point(17, 18);
            lblStatusKonfirmasiDonatur.Margin = new Padding(2, 0, 2, 0);
            lblStatusKonfirmasiDonatur.Name = "lblStatusKonfirmasiDonatur";
            lblStatusKonfirmasiDonatur.Size = new Size(159, 28);
            lblStatusKonfirmasiDonatur.TabIndex = 2;
            lblStatusKonfirmasiDonatur.Text = "Riwayat Donasi";
            lblStatusKonfirmasiDonatur.Click += lblStatusKonfirmasiDonatur_Click;
            // 
            // pnlDaftar
            // 
            pnlDaftar.BackColor = Color.White;
            pnlDaftar.Controls.Add(btnDonasiDonatur);
            pnlDaftar.Controls.Add(btnLoadData);
            pnlDaftar.Controls.Add(dgvPermintaanDonasi);
            pnlDaftar.Controls.Add(lblDaftarPermintaan);
            pnlDaftar.Location = new Point(348, 82);
            pnlDaftar.Margin = new Padding(2);
            pnlDaftar.Name = "pnlDaftar";
            pnlDaftar.Size = new Size(500, 500);
            pnlDaftar.TabIndex = 3;
            // 
            // btnLoadData
            // 
            btnLoadData.BackColor = Color.LightSlateGray;
            btnLoadData.FlatAppearance.BorderSize = 0;
            btnLoadData.FlatStyle = FlatStyle.Flat;
            btnLoadData.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadData.ForeColor = Color.White;
            btnLoadData.Location = new Point(318, 452);
            btnLoadData.Margin = new Padding(2);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(158, 31);
            btnLoadData.TabIndex = 6;
            btnLoadData.Text = "Muat Ulang";
            btnLoadData.UseVisualStyleBackColor = false;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // dgvPermintaanDonasi
            // 
            dgvPermintaanDonasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermintaanDonasi.Location = new Point(18, 62);
            dgvPermintaanDonasi.Margin = new Padding(2);
            dgvPermintaanDonasi.Name = "dgvPermintaanDonasi";
            dgvPermintaanDonasi.RowHeadersWidth = 82;
            dgvPermintaanDonasi.RowTemplate.Height = 41;
            dgvPermintaanDonasi.Size = new Size(458, 376);
            dgvPermintaanDonasi.TabIndex = 1;
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
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Keluar";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnDonasiDonatur
            // 
            btnDonasiDonatur.BackColor = Color.DodgerBlue;
            btnDonasiDonatur.FlatAppearance.BorderSize = 0;
            btnDonasiDonatur.FlatStyle = FlatStyle.Flat;
            btnDonasiDonatur.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnDonasiDonatur.ForeColor = Color.White;
            btnDonasiDonatur.Location = new Point(156, 452);
            btnDonasiDonatur.Margin = new Padding(2);
            btnDonasiDonatur.Name = "btnDonasiDonatur";
            btnDonasiDonatur.Size = new Size(158, 31);
            btnDonasiDonatur.TabIndex = 5;
            btnDonasiDonatur.Text = "Donasi";
            btnDonasiDonatur.UseVisualStyleBackColor = false;
            btnDonasiDonatur.Click += btnDonasiDonatur_Click_1;
            // 
            // DonaturForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(870, 596);
            Controls.Add(btnLogOut);
            Controls.Add(pnlDaftar);
            Controls.Add(pnlRiwayat);
            Controls.Add(pnlHeader);
            Margin = new Padding(2);
            Name = "DonaturForm";
            Text = "Pengirim Donatur";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlRiwayat.ResumeLayout(false);
            pnlRiwayat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonasiDonatur).EndInit();
            pnlDaftar.ResumeLayout(false);
            pnlDaftar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPermintaanDonasi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblDonatur;
        private Label lblUsernameDonatur;
        private Label lblBrand;
        private Panel pnlRiwayat;
        private DataGridView dgvDonasiDonatur;
        private Label lblStatusKonfirmasiDonatur;
        private Panel pnlDaftar;
        private Button btnLoadData;
        private DataGridView dgvPermintaanDonasi;
        private Label lblDaftarPermintaan;
        private Button btnLogOut;
        private Button btnDonasiDonatur;
    }
}