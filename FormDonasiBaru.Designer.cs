namespace Dish4Good_v2
{
    partial class FormDonasiBaru
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
            cmbJenisDonasi = new ComboBox();
            txtPesanDonasi = new RichTextBox();
            lblJenisDonasi = new Label();
            lblPesanDonasi = new Label();
            lblJudulForm = new Label();
            btnTambahDonasi = new Button();
            SuspendLayout();
            // 
            // cmbJenisDonasi
            // 
            cmbJenisDonasi.FormattingEnabled = true;
            cmbJenisDonasi.Location = new Point(189, 106);
            cmbJenisDonasi.Name = "cmbJenisDonasi";
            cmbJenisDonasi.Size = new Size(353, 28);
            cmbJenisDonasi.TabIndex = 0;
            // 
            // txtPesanDonasi
            // 
            txtPesanDonasi.Location = new Point(189, 174);
            txtPesanDonasi.Name = "txtPesanDonasi";
            txtPesanDonasi.Size = new Size(493, 198);
            txtPesanDonasi.TabIndex = 2;
            txtPesanDonasi.Text = "";
            // 
            // lblJenisDonasi
            // 
            lblJenisDonasi.AutoSize = true;
            lblJenisDonasi.Location = new Point(74, 109);
            lblJenisDonasi.Name = "lblJenisDonasi";
            lblJenisDonasi.Size = new Size(93, 20);
            lblJenisDonasi.TabIndex = 3;
            lblJenisDonasi.Text = "Jenis Donasi:";
            // 
            // lblPesanDonasi
            // 
            lblPesanDonasi.AutoSize = true;
            lblPesanDonasi.Location = new Point(40, 174);
            lblPesanDonasi.Name = "lblPesanDonasi";
            lblPesanDonasi.Size = new Size(127, 20);
            lblPesanDonasi.TabIndex = 4;
            lblPesanDonasi.Text = "Pesan Permintaan:";
            // 
            // lblJudulForm
            // 
            lblJudulForm.AutoSize = true;
            lblJudulForm.Location = new Point(243, 27);
            lblJudulForm.Name = "lblJudulForm";
            lblJudulForm.Size = new Size(283, 20);
            lblJudulForm.TabIndex = 5;
            lblJudulForm.Text = "Form Pembuatan Permintaan Donasi Baru";
            // 
            // btnTambahDonasi
            // 
            btnTambahDonasi.Location = new Point(588, 378);
            btnTambahDonasi.Name = "btnTambahDonasi";
            btnTambahDonasi.Size = new Size(94, 29);
            btnTambahDonasi.TabIndex = 6;
            btnTambahDonasi.Text = "Tambah";
            btnTambahDonasi.UseVisualStyleBackColor = true;
            btnTambahDonasi.Click += btnTambahDonasi_Click_1;
            // 
            // FormDonasiBaru
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTambahDonasi);
            Controls.Add(lblJudulForm);
            Controls.Add(lblPesanDonasi);
            Controls.Add(lblJenisDonasi);
            Controls.Add(txtPesanDonasi);
            Controls.Add(cmbJenisDonasi);
            Name = "FormDonasiBaru";
            Text = "FormDonasiBaru";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbJenisDonasi;
        private RichTextBox txtPesanDonasi;
        private Label lblJenisDonasi;
        private Label lblPesanDonasi;
        private Label lblJudulForm;
        private Button btnTambahDonasi;
    }
}