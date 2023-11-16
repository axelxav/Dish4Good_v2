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
            btnDonasiDonatur = new Button();
            btnLoadData = new Button();
            dgvPermintaanDonasi = new DataGridView();
            lblDaftarPermintaan = new Label();
            btnLogOut = new Button();
            pnlAkunInfo = new Panel();
            pnlHeader.SuspendLayout();
            pnlRiwayat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonasiDonatur).BeginInit();
            pnlDaftar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPermintaanDonasi).BeginInit();
            pnlAkunInfo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(pnlAkunInfo);
            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1415, 99);
            pnlHeader.TabIndex = 1;
            // 
            // lblDonatur
            // 
            lblDonatur.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDonatur.AutoSize = true;
            lblDonatur.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonatur.Location = new Point(121, 51);
            lblDonatur.Name = "lblDonatur";
            lblDonatur.Size = new Size(87, 25);
            lblDonatur.TabIndex = 4;
            lblDonatur.Text = "Donatur";
            lblDonatur.TextAlign = ContentAlignment.TopRight;
            // 
            // lblUsernameDonatur
            // 
            lblUsernameDonatur.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsernameDonatur.AutoSize = true;
            lblUsernameDonatur.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsernameDonatur.Location = new Point(17, 7);
            lblUsernameDonatur.Name = "lblUsernameDonatur";
            lblUsernameDonatur.Size = new Size(191, 32);
            lblUsernameDonatur.TabIndex = 3;
            lblUsernameDonatur.Text = "Nama Pengguna";
            lblUsernameDonatur.TextAlign = ContentAlignment.TopRight;
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
            pnlRiwayat.AutoSize = true;
            pnlRiwayat.BackColor = Color.White;
            pnlRiwayat.Controls.Add(dgvDonasiDonatur);
            pnlRiwayat.Controls.Add(lblStatusKonfirmasiDonatur);
            pnlRiwayat.Location = new Point(32, 131);
            pnlRiwayat.Name = "pnlRiwayat";
            pnlRiwayat.Size = new Size(496, 730);
            pnlRiwayat.TabIndex = 2;
            // 
            // dgvDonasiDonatur
            // 
            dgvDonasiDonatur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDonasiDonatur.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvDonasiDonatur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonasiDonatur.Location = new Point(28, 99);
            dgvDonasiDonatur.Name = "dgvDonasiDonatur";
            dgvDonasiDonatur.RowHeadersWidth = 82;
            dgvDonasiDonatur.RowTemplate.Height = 41;
            dgvDonasiDonatur.Size = new Size(439, 602);
            dgvDonasiDonatur.TabIndex = 3;
            // 
            // lblStatusKonfirmasiDonatur
            // 
            lblStatusKonfirmasiDonatur.AutoSize = true;
            lblStatusKonfirmasiDonatur.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatusKonfirmasiDonatur.Location = new Point(28, 29);
            lblStatusKonfirmasiDonatur.Name = "lblStatusKonfirmasiDonatur";
            lblStatusKonfirmasiDonatur.Size = new Size(251, 45);
            lblStatusKonfirmasiDonatur.TabIndex = 2;
            lblStatusKonfirmasiDonatur.Text = "Riwayat Donasi";
            lblStatusKonfirmasiDonatur.Click += lblStatusKonfirmasiDonatur_Click;
            // 
            // pnlDaftar
            // 
            pnlDaftar.AutoSize = true;
            pnlDaftar.BackColor = Color.White;
            pnlDaftar.Controls.Add(btnDonasiDonatur);
            pnlDaftar.Controls.Add(btnLoadData);
            pnlDaftar.Controls.Add(dgvPermintaanDonasi);
            pnlDaftar.Controls.Add(lblDaftarPermintaan);
            pnlDaftar.Location = new Point(566, 131);
            pnlDaftar.Name = "pnlDaftar";
            pnlDaftar.Size = new Size(812, 800);
            pnlDaftar.TabIndex = 3;
            // 
            // btnDonasiDonatur
            // 
            btnDonasiDonatur.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDonasiDonatur.BackColor = Color.DodgerBlue;
            btnDonasiDonatur.FlatAppearance.BorderSize = 0;
            btnDonasiDonatur.FlatStyle = FlatStyle.Flat;
            btnDonasiDonatur.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnDonasiDonatur.ForeColor = Color.White;
            btnDonasiDonatur.Location = new Point(254, 723);
            btnDonasiDonatur.Name = "btnDonasiDonatur";
            btnDonasiDonatur.Size = new Size(257, 50);
            btnDonasiDonatur.TabIndex = 5;
            btnDonasiDonatur.Text = "Donasi";
            btnDonasiDonatur.UseVisualStyleBackColor = false;
            btnDonasiDonatur.Click += btnDonasiDonatur_Click_1;
            // 
            // btnLoadData
            // 
            btnLoadData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLoadData.BackColor = Color.LightSlateGray;
            btnLoadData.FlatAppearance.BorderSize = 0;
            btnLoadData.FlatStyle = FlatStyle.Flat;
            btnLoadData.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadData.ForeColor = Color.White;
            btnLoadData.Location = new Point(517, 723);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(257, 50);
            btnLoadData.TabIndex = 6;
            btnLoadData.Text = "Muat Ulang";
            btnLoadData.UseVisualStyleBackColor = false;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // dgvPermintaanDonasi
            // 
            dgvPermintaanDonasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPermintaanDonasi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvPermintaanDonasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermintaanDonasi.Location = new Point(29, 99);
            dgvPermintaanDonasi.Name = "dgvPermintaanDonasi";
            dgvPermintaanDonasi.RowHeadersWidth = 82;
            dgvPermintaanDonasi.RowTemplate.Height = 41;
            dgvPermintaanDonasi.Size = new Size(744, 602);
            dgvPermintaanDonasi.TabIndex = 1;
            // 
            // lblDaftarPermintaan
            // 
            lblDaftarPermintaan.AutoSize = true;
            lblDaftarPermintaan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDaftarPermintaan.Location = new Point(29, 29);
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
            btnLogOut.Size = new Size(496, 50);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Keluar";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // pnlAkunInfo
            // 
            pnlAkunInfo.BackColor = Color.Transparent;
            pnlAkunInfo.Controls.Add(lblUsernameDonatur);
            pnlAkunInfo.Controls.Add(lblDonatur);
            pnlAkunInfo.Location = new Point(1170, 2);
            pnlAkunInfo.Name = "pnlAkunInfo";
            pnlAkunInfo.Size = new Size(208, 94);
            pnlAkunInfo.TabIndex = 5;
            // 
            // DonaturForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1414, 954);
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
            ((System.ComponentModel.ISupportInitialize)dgvDonasiDonatur).EndInit();
            pnlDaftar.ResumeLayout(false);
            pnlDaftar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPermintaanDonasi).EndInit();
            pnlAkunInfo.ResumeLayout(false);
            pnlAkunInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Panel pnlAkunInfo;
    }
}