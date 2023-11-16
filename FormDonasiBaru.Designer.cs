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
            cmbJenisDonasi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbJenisDonasi.FormattingEnabled = true;
            cmbJenisDonasi.Location = new Point(307, 170);
            cmbJenisDonasi.Margin = new Padding(5);
            cmbJenisDonasi.Name = "cmbJenisDonasi";
            cmbJenisDonasi.Size = new Size(378, 40);
            cmbJenisDonasi.TabIndex = 0;
            // 
            // txtPesanDonasi
            // 
            txtPesanDonasi.Location = new Point(307, 278);
            txtPesanDonasi.Margin = new Padding(5);
            txtPesanDonasi.Name = "txtPesanDonasi";
            txtPesanDonasi.Size = new Size(843, 314);
            txtPesanDonasi.TabIndex = 2;
            txtPesanDonasi.Text = "";
            // 
            // lblJenisDonasi
            // 
            lblJenisDonasi.AutoSize = true;
            lblJenisDonasi.ForeColor = Color.Gainsboro;
            lblJenisDonasi.Location = new Point(120, 174);
            lblJenisDonasi.Margin = new Padding(5, 0, 5, 0);
            lblJenisDonasi.Name = "lblJenisDonasi";
            lblJenisDonasi.Size = new Size(151, 32);
            lblJenisDonasi.TabIndex = 3;
            lblJenisDonasi.Text = "Jenis Donasi:";
            // 
            // lblPesanDonasi
            // 
            lblPesanDonasi.AutoSize = true;
            lblPesanDonasi.ForeColor = Color.Gainsboro;
            lblPesanDonasi.Location = new Point(65, 278);
            lblPesanDonasi.Margin = new Padding(5, 0, 5, 0);
            lblPesanDonasi.Name = "lblPesanDonasi";
            lblPesanDonasi.Size = new Size(207, 32);
            lblPesanDonasi.TabIndex = 4;
            lblPesanDonasi.Text = "Pesan Permintaan:";
            // 
            // lblJudulForm
            // 
            lblJudulForm.AutoSize = true;
            lblJudulForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblJudulForm.ForeColor = Color.White;
            lblJudulForm.Location = new Point(307, 78);
            lblJudulForm.Margin = new Padding(5, 0, 5, 0);
            lblJudulForm.Name = "lblJudulForm";
            lblJudulForm.Size = new Size(648, 45);
            lblJudulForm.TabIndex = 5;
            lblJudulForm.Text = "Form Pembuatan Permintaan Donasi Baru";
            // 
            // btnTambahDonasi
            // 
            btnTambahDonasi.BackColor = Color.DodgerBlue;
            btnTambahDonasi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTambahDonasi.ForeColor = Color.White;
            btnTambahDonasi.Location = new Point(956, 617);
            btnTambahDonasi.Margin = new Padding(5);
            btnTambahDonasi.Name = "btnTambahDonasi";
            btnTambahDonasi.Size = new Size(194, 58);
            btnTambahDonasi.TabIndex = 6;
            btnTambahDonasi.Text = "Tambah";
            btnTambahDonasi.UseVisualStyleBackColor = false;
            btnTambahDonasi.Click += btnTambahDonasi_Click_1;
            // 
            // FormDonasiBaru
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1300, 720);
            Controls.Add(btnTambahDonasi);
            Controls.Add(lblJudulForm);
            Controls.Add(lblPesanDonasi);
            Controls.Add(lblJenisDonasi);
            Controls.Add(txtPesanDonasi);
            Controls.Add(cmbJenisDonasi);
            Margin = new Padding(5);
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