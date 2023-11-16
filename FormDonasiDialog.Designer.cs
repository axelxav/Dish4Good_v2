namespace Dish4Good_v2
{
    partial class FormDonasiDialog
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
            tbPesanDonasi = new RichTextBox();
            lbPesanDonasi = new Label();
            btnCancel = new Button();
            btnSubmit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbPesanDonasi
            // 
            tbPesanDonasi.Location = new Point(75, 263);
            tbPesanDonasi.Margin = new Padding(5);
            tbPesanDonasi.Name = "tbPesanDonasi";
            tbPesanDonasi.Size = new Size(799, 279);
            tbPesanDonasi.TabIndex = 0;
            tbPesanDonasi.Text = "";
            // 
            // lbPesanDonasi
            // 
            lbPesanDonasi.AutoSize = true;
            lbPesanDonasi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbPesanDonasi.ForeColor = Color.LightGray;
            lbPesanDonasi.Location = new Point(75, 225);
            lbPesanDonasi.Margin = new Padding(5, 0, 5, 0);
            lbPesanDonasi.Name = "lbPesanDonasi";
            lbPesanDonasi.Size = new Size(152, 32);
            lbPesanDonasi.TabIndex = 1;
            lbPesanDonasi.Text = "Ketik Donasi:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Firebrick;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(543, 569);
            btnCancel.Margin = new Padding(5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(153, 46);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DodgerBlue;
            btnSubmit.FlatAppearance.BorderColor = Color.LightSteelBlue;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(721, 569);
            btnSubmit.Margin = new Padding(5);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(153, 46);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(75, 105);
            label1.Name = "label1";
            label1.Size = new Size(425, 59);
            label1.TabIndex = 4;
            label1.Text = "Kirim Donasi Kamu!";
            // 
            // FormDonasiDialog
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(1020, 720);
            Controls.Add(label1);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            Controls.Add(lbPesanDonasi);
            Controls.Add(tbPesanDonasi);
            Margin = new Padding(5);
            Name = "FormDonasiDialog";
            Text = "FormDonasiDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox tbPesanDonasi;
        private Label lbPesanDonasi;
        private Button btnCancel;
        private Button btnSubmit;
        private Label label1;
    }
}