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
            SuspendLayout();
            // 
            // tbPesanDonasi
            // 
            tbPesanDonasi.Location = new Point(151, 167);
            tbPesanDonasi.Name = "tbPesanDonasi";
            tbPesanDonasi.Size = new Size(493, 176);
            tbPesanDonasi.TabIndex = 0;
            tbPesanDonasi.Text = "";
            // 
            // lbPesanDonasi
            // 
            lbPesanDonasi.AutoSize = true;
            lbPesanDonasi.Location = new Point(46, 167);
            lbPesanDonasi.Name = "lbPesanDonasi";
            lbPesanDonasi.Size = new Size(99, 20);
            lbPesanDonasi.TabIndex = 1;
            lbPesanDonasi.Text = "Pesan Donasi:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(420, 373);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(550, 373);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // FormDonasiDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(btnCancel);
            Controls.Add(lbPesanDonasi);
            Controls.Add(tbPesanDonasi);
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
    }
}