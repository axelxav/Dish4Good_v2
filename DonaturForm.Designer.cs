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
            lblUsername = new Label();
            lblBrand = new Label();
            pnlRiwayat = new Panel();
            dataGridViewRiwayatDonasi = new DataGridView();
            lblStatusKonfirmasiDonatur = new Label();
            pnlDaftar = new Panel();
            btnLoadData = new Button();
            dataGridViewPermintaanDonasi = new DataGridView();
            lblDaftarPermintaan = new Label();
            btnLogOut = new Button();
            pnlHeader.SuspendLayout();
            pnlRiwayat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRiwayatDonasi).BeginInit();
            pnlDaftar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPermintaanDonasi).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblDonatur);
            pnlHeader.Controls.Add(lblUsername);
            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1416, 100);
            pnlHeader.TabIndex = 1;
            // 
            // lblDonatur
            // 
            lblDonatur.AutoSize = true;
            lblDonatur.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonatur.Location = new Point(1283, 57);
            lblDonatur.Name = "lblDonatur";
            lblDonatur.Size = new Size(87, 25);
            lblDonatur.TabIndex = 4;
            lblDonatur.Text = "Donatur";
            lblDonatur.TextAlign = ContentAlignment.TopRight;
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
            // pnlRiwayat
            // 
            pnlRiwayat.BackColor = Color.White;
            pnlRiwayat.Controls.Add(dataGridViewRiwayatDonasi);
            pnlRiwayat.Controls.Add(lblStatusKonfirmasiDonatur);
            pnlRiwayat.Location = new Point(32, 132);
            pnlRiwayat.Name = "pnlRiwayat";
            pnlRiwayat.Size = new Size(496, 729);
            pnlRiwayat.TabIndex = 2;
            // 
            // dataGridViewRiwayatDonasi
            // 
            dataGridViewRiwayatDonasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRiwayatDonasi.Location = new Point(28, 99);
            dataGridViewRiwayatDonasi.Name = "dataGridViewRiwayatDonasi";
            dataGridViewRiwayatDonasi.RowHeadersWidth = 82;
            dataGridViewRiwayatDonasi.RowTemplate.Height = 41;
            dataGridViewRiwayatDonasi.Size = new Size(439, 602);
            dataGridViewRiwayatDonasi.TabIndex = 3;
            // 
            // lblStatusKonfirmasiDonatur
            // 
            lblStatusKonfirmasiDonatur.AutoSize = true;
            lblStatusKonfirmasiDonatur.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatusKonfirmasiDonatur.Location = new Point(28, 28);
            lblStatusKonfirmasiDonatur.Name = "lblStatusKonfirmasiDonatur";
            lblStatusKonfirmasiDonatur.Size = new Size(251, 45);
            lblStatusKonfirmasiDonatur.TabIndex = 2;
            lblStatusKonfirmasiDonatur.Text = "Riwayat Donasi";
            lblStatusKonfirmasiDonatur.Click += lblStatusKonfirmasiDonatur_Click;
            // 
            // pnlDaftar
            // 
            pnlDaftar.BackColor = Color.White;
            pnlDaftar.Controls.Add(btnLoadData);
            pnlDaftar.Controls.Add(dataGridViewPermintaanDonasi);
            pnlDaftar.Controls.Add(lblDaftarPermintaan);
            pnlDaftar.Location = new Point(566, 132);
            pnlDaftar.Name = "pnlDaftar";
            pnlDaftar.Size = new Size(812, 800);
            pnlDaftar.TabIndex = 3;
            // 
            // btnLoadData
            // 
            btnLoadData.BackColor = Color.LightSlateGray;
            btnLoadData.FlatAppearance.BorderSize = 0;
            btnLoadData.FlatStyle = FlatStyle.Flat;
            btnLoadData.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadData.ForeColor = Color.White;
            btnLoadData.Location = new Point(517, 724);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(256, 49);
            btnLoadData.TabIndex = 6;
            btnLoadData.Text = "Muat Ulang";
            btnLoadData.UseVisualStyleBackColor = false;
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
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Keluar";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // DonaturForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1414, 953);
            Controls.Add(btnLogOut);
            Controls.Add(pnlDaftar);
            Controls.Add(pnlRiwayat);
            Controls.Add(pnlHeader);
            Name = "DonaturForm";
            Text = "Pengirim Donatur";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlRiwayat.ResumeLayout(false);
            pnlRiwayat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRiwayatDonasi).EndInit();
            pnlDaftar.ResumeLayout(false);
            pnlDaftar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPermintaanDonasi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblDonatur;
        private Label lblUsername;
        private Label lblBrand;
        private Panel pnlRiwayat;
        private DataGridView dataGridViewRiwayatDonasi;
        private Label lblStatusKonfirmasiDonatur;
        private Panel pnlDaftar;
        private Button btnLoadData;
        private DataGridView dataGridViewPermintaanDonasi;
        private Label lblDaftarPermintaan;
        private Button btnLogOut;
    }
}