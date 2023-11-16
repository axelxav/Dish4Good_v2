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
            lblUsernameDonatur = new Label();
            lblDonatur = new Label();
            lblBrand = new Label();
            pnlRiwayat = new Panel();
            btnLogOut = new Button();
            dgvDonasiDonatur = new DataGridView();
            lblStatusKonfirmasiDonatur = new Label();
            pnlDaftar = new Panel();
            btnDonasiDonatur = new Button();
            btnLoadData = new Button();
            dgvPermintaanDonasi = new DataGridView();
            lblDaftarPermintaan = new Label();
            lblRoleUser = new Label();
            lblNamaUser = new Label();
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
            pnlHeader.Controls.Add(lblNamaUser);
            pnlHeader.Controls.Add(lblRoleUser);
            pnlHeader.Controls.Add(lblDonatur);
            pnlHeader.Controls.Add(lblUsernameDonatur);
            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(20, 0, 20, 0);
            pnlHeader.Size = new Size(1422, 62);
            pnlHeader.TabIndex = 1;
            // 
            // lblUsernameDonatur
            // 
            lblUsernameDonatur.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsernameDonatur.AutoSize = true;
            lblUsernameDonatur.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsernameDonatur.Location = new Point(1284, 29);
            lblUsernameDonatur.Margin = new Padding(2, 0, 2, 0);
            lblUsernameDonatur.Name = "lblUsernameDonatur";
            lblUsernameDonatur.Size = new Size(118, 20);
            lblUsernameDonatur.TabIndex = 3;
            lblUsernameDonatur.Text = "Nama Pengguna";
            lblUsernameDonatur.TextAlign = ContentAlignment.TopRight;
            lblUsernameDonatur.Click += lblUsernameDonatur_Click;
            // 
            // lblDonatur
            // 
            lblDonatur.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDonatur.AutoSize = true;
            lblDonatur.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonatur.Location = new Point(1284, 9);
            lblDonatur.Margin = new Padding(2, 0, 2, 0);
            lblDonatur.Name = "lblDonatur";
            lblDonatur.Size = new Size(53, 15);
            lblDonatur.TabIndex = 4;
            lblDonatur.Text = "Donatur";
            lblDonatur.TextAlign = ContentAlignment.TopRight;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblBrand.Location = new Point(40, 12);
            lblBrand.Margin = new Padding(2, 0, 2, 0);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(159, 37);
            lblBrand.TabIndex = 2;
            lblBrand.Text = "Dish4Good";
            // 
            // pnlRiwayat
            // 
            pnlRiwayat.AutoSize = true;
            pnlRiwayat.BackColor = Color.White;
            pnlRiwayat.Controls.Add(btnLogOut);
            pnlRiwayat.Controls.Add(dgvDonasiDonatur);
            pnlRiwayat.Controls.Add(lblStatusKonfirmasiDonatur);
            pnlRiwayat.Location = new Point(20, 82);
            pnlRiwayat.Margin = new Padding(2);
            pnlRiwayat.Name = "pnlRiwayat";
            pnlRiwayat.Size = new Size(579, 503);
            pnlRiwayat.TabIndex = 2;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Firebrick;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(17, 452);
            btnLogOut.Margin = new Padding(2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(305, 31);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Keluar";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // dgvDonasiDonatur
            // 
            dgvDonasiDonatur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDonasiDonatur.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvDonasiDonatur.BackgroundColor = Color.Gainsboro;
            dgvDonasiDonatur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonasiDonatur.GridColor = Color.Gainsboro;
            dgvDonasiDonatur.Location = new Point(17, 62);
            dgvDonasiDonatur.Margin = new Padding(2);
            dgvDonasiDonatur.Name = "dgvDonasiDonatur";
            dgvDonasiDonatur.RowHeadersWidth = 82;
            dgvDonasiDonatur.RowTemplate.Height = 41;
            dgvDonasiDonatur.Size = new Size(539, 376);
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
            pnlDaftar.AutoSize = true;
            pnlDaftar.BackColor = Color.White;
            pnlDaftar.Controls.Add(btnDonasiDonatur);
            pnlDaftar.Controls.Add(btnLoadData);
            pnlDaftar.Controls.Add(dgvPermintaanDonasi);
            pnlDaftar.Controls.Add(lblDaftarPermintaan);
            pnlDaftar.Location = new Point(618, 82);
            pnlDaftar.Margin = new Padding(2);
            pnlDaftar.Name = "pnlDaftar";
            pnlDaftar.Size = new Size(782, 500);
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
            btnDonasiDonatur.Location = new Point(438, 452);
            btnDonasiDonatur.Margin = new Padding(2);
            btnDonasiDonatur.Name = "btnDonasiDonatur";
            btnDonasiDonatur.Size = new Size(158, 31);
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
            btnLoadData.Location = new Point(600, 452);
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
            dgvPermintaanDonasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPermintaanDonasi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvPermintaanDonasi.BackgroundColor = Color.Gainsboro;
            dgvPermintaanDonasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermintaanDonasi.GridColor = Color.Gainsboro;
            dgvPermintaanDonasi.Location = new Point(18, 62);
            dgvPermintaanDonasi.Margin = new Padding(2);
            dgvPermintaanDonasi.Name = "dgvPermintaanDonasi";
            dgvPermintaanDonasi.RowHeadersWidth = 82;
            dgvPermintaanDonasi.RowTemplate.Height = 41;
            dgvPermintaanDonasi.Size = new Size(740, 376);
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
            // lblRoleUser
            // 
            lblRoleUser.AutoSize = true;
            lblRoleUser.Location = new Point(1237, 5);
            lblRoleUser.Name = "lblRoleUser";
            lblRoleUser.Size = new Size(42, 20);
            lblRoleUser.TabIndex = 6;
            lblRoleUser.Text = "Role:";
            // 
            // lblNamaUser
            // 
            lblNamaUser.AutoSize = true;
            lblNamaUser.Location = new Point(1194, 29);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(85, 20);
            lblNamaUser.TabIndex = 7;
            lblNamaUser.Text = "Nama User:";
            // 
            // DonaturForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1422, 596);
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
        private Label lblRoleUser;
        private Label lblNamaUser;
    }
}