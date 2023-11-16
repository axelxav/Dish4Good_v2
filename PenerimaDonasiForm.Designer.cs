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
            lblNamaUser = new Label();
            lblRoleUser = new Label();
            lblUsername = new Label();
            lblPenerima = new Label();
            lblBrand = new Label();
            pnlKonfirmasi = new Panel();
            panel2 = new Panel();
            dgvDonasiTerpenuhi = new DataGridView();
            btnLogOut = new Button();
            lblPermintaanBerhasil = new Label();
            pnlDaftar = new Panel();
            panel5 = new Panel();
            btnDelete = new Button();
            btnLoadData = new Button();
            panel4 = new Panel();
            lblDaftarPermintaan = new Label();
            btnTambah = new Button();
            dgvDonasi = new DataGridView();
            panel1 = new Panel();
            pnlHeader.SuspendLayout();
            pnlKonfirmasi.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonasiTerpenuhi).BeginInit();
            pnlDaftar.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonasi).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblNamaUser);
            pnlHeader.Controls.Add(lblRoleUser);
            pnlHeader.Controls.Add(lblUsername);
            pnlHeader.Controls.Add(lblPenerima);
            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1422, 62);
            pnlHeader.TabIndex = 0;
            // 
            // lblNamaUser
            // 
            lblNamaUser.AutoSize = true;
            lblNamaUser.Location = new Point(1194, 29);
            lblNamaUser.Name = "lblNamaUser";
            lblNamaUser.Size = new Size(85, 20);
            lblNamaUser.TabIndex = 6;
            lblNamaUser.Text = "Nama User:";
            // 
            // lblRoleUser
            // 
            lblRoleUser.AutoSize = true;
            lblRoleUser.Location = new Point(1237, 5);
            lblRoleUser.Name = "lblRoleUser";
            lblRoleUser.Size = new Size(42, 20);
            lblRoleUser.TabIndex = 5;
            lblRoleUser.Text = "Role:";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = AnchorStyles.Right;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(1284, 29);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.RightToLeft = RightToLeft.Yes;
            lblUsername.Size = new Size(118, 20);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Nama Pengguna";
            lblUsername.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPenerima
            // 
            lblPenerima.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPenerima.AutoSize = true;
            lblPenerima.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            lblPenerima.Location = new Point(1284, 9);
            lblPenerima.Margin = new Padding(2, 0, 2, 0);
            lblPenerima.Name = "lblPenerima";
            lblPenerima.RightToLeft = RightToLeft.Yes;
            lblPenerima.Size = new Size(60, 15);
            lblPenerima.TabIndex = 4;
            lblPenerima.Text = "Penerima";
            lblPenerima.TextAlign = ContentAlignment.TopRight;
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
            // pnlKonfirmasi
            // 
            pnlKonfirmasi.AutoSize = true;
            pnlKonfirmasi.BackColor = Color.White;
            pnlKonfirmasi.Controls.Add(panel2);
            pnlKonfirmasi.Controls.Add(btnLogOut);
            pnlKonfirmasi.Controls.Add(lblPermintaanBerhasil);
            pnlKonfirmasi.Dock = DockStyle.Left;
            pnlKonfirmasi.Location = new Point(20, 20);
            pnlKonfirmasi.Margin = new Padding(2);
            pnlKonfirmasi.Name = "pnlKonfirmasi";
            pnlKonfirmasi.Size = new Size(579, 494);
            pnlKonfirmasi.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvDonasiTerpenuhi);
            panel2.Location = new Point(17, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(559, 400);
            panel2.TabIndex = 4;
            // 
            // dgvDonasiTerpenuhi
            // 
            dgvDonasiTerpenuhi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDonasiTerpenuhi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvDonasiTerpenuhi.BackgroundColor = Color.Gainsboro;
            dgvDonasiTerpenuhi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonasiTerpenuhi.GridColor = Color.Gainsboro;
            dgvDonasiTerpenuhi.Location = new Point(3, 10);
            dgvDonasiTerpenuhi.Margin = new Padding(2);
            dgvDonasiTerpenuhi.Name = "dgvDonasiTerpenuhi";
            dgvDonasiTerpenuhi.RowHeadersWidth = 82;
            dgvDonasiTerpenuhi.RowTemplate.Height = 41;
            dgvDonasiTerpenuhi.Size = new Size(540, 376);
            dgvDonasiTerpenuhi.TabIndex = 3;
            dgvDonasiTerpenuhi.CellContentClick += dgvDonasiTerpenuhi_CellContentClick;
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
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Keluar";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click_1;
            // 
            // lblPermintaanBerhasil
            // 
            lblPermintaanBerhasil.AutoSize = true;
            lblPermintaanBerhasil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPermintaanBerhasil.Location = new Point(17, 9);
            lblPermintaanBerhasil.Margin = new Padding(2, 0, 2, 0);
            lblPermintaanBerhasil.Name = "lblPermintaanBerhasil";
            lblPermintaanBerhasil.Size = new Size(202, 28);
            lblPermintaanBerhasil.TabIndex = 2;
            lblPermintaanBerhasil.Text = "Permintaan Berhasil";
            // 
            // pnlDaftar
            // 
            pnlDaftar.AutoSize = true;
            pnlDaftar.BackColor = Color.White;
            pnlDaftar.Controls.Add(panel5);
            pnlDaftar.Controls.Add(panel4);
            pnlDaftar.Controls.Add(dgvDonasi);
            pnlDaftar.Location = new Point(626, 20);
            pnlDaftar.Margin = new Padding(2);
            pnlDaftar.Name = "pnlDaftar";
            pnlDaftar.Size = new Size(776, 494);
            pnlDaftar.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnDelete);
            panel5.Controls.Add(btnLoadData);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 435);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(20, 0, 20, 0);
            panel5.Size = new Size(776, 59);
            panel5.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.White;
            btnDelete.FlatAppearance.BorderColor = Color.Firebrick;
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Firebrick;
            btnDelete.Location = new Point(475, 17);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 31);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Hapus";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoadData
            // 
            btnLoadData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLoadData.BackColor = Color.LightSlateGray;
            btnLoadData.FlatAppearance.BorderSize = 0;
            btnLoadData.FlatStyle = FlatStyle.Flat;
            btnLoadData.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoadData.ForeColor = Color.White;
            btnLoadData.Location = new Point(594, 17);
            btnLoadData.Margin = new Padding(2);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(160, 31);
            btnLoadData.TabIndex = 6;
            btnLoadData.Text = "Muat Ulang";
            btnLoadData.UseVisualStyleBackColor = false;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblDaftarPermintaan);
            panel4.Controls.Add(btnTambah);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20, 8, 20, 8);
            panel4.Size = new Size(776, 54);
            panel4.TabIndex = 7;
            // 
            // lblDaftarPermintaan
            // 
            lblDaftarPermintaan.AutoSize = true;
            lblDaftarPermintaan.Dock = DockStyle.Left;
            lblDaftarPermintaan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDaftarPermintaan.Location = new Point(20, 8);
            lblDaftarPermintaan.Margin = new Padding(2, 0, 2, 0);
            lblDaftarPermintaan.Name = "lblDaftarPermintaan";
            lblDaftarPermintaan.Size = new Size(187, 28);
            lblDaftarPermintaan.TabIndex = 0;
            lblDaftarPermintaan.Text = "Daftar Permintaan";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.DodgerBlue;
            btnTambah.Dock = DockStyle.Right;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI", 7F, FontStyle.Bold, GraphicsUnit.Point);
            btnTambah.ForeColor = Color.White;
            btnTambah.Location = new Point(596, 8);
            btnTambah.Margin = new Padding(2);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(160, 38);
            btnTambah.TabIndex = 4;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // dgvDonasi
            // 
            dgvDonasi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDonasi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvDonasi.BackgroundColor = Color.Gainsboro;
            dgvDonasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonasi.GridColor = Color.Gainsboro;
            dgvDonasi.Location = new Point(20, 59);
            dgvDonasi.Margin = new Padding(2);
            dgvDonasi.Name = "dgvDonasi";
            dgvDonasi.RowHeadersWidth = 82;
            dgvDonasi.RowTemplate.Height = 41;
            dgvDonasi.Size = new Size(736, 376);
            dgvDonasi.TabIndex = 1;
            dgvDonasi.CellContentClick += dgvDonasi_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlKonfirmasi);
            panel1.Controls.Add(pnlDaftar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 62);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(1422, 534);
            panel1.TabIndex = 4;
            // 
            // PenerimaDonasiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1422, 596);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            Margin = new Padding(2);
            Name = "PenerimaDonasiForm";
            Text = "Penerima Donasi";
            Load += PenerimaDonasiForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlKonfirmasi.ResumeLayout(false);
            pnlKonfirmasi.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDonasiTerpenuhi).EndInit();
            pnlDaftar.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonasi).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel2;
        private Label lblNamaUser;
        private Label lblRoleUser;
    }
}