namespace Dish4Good_v2
{
    partial class FormRegistrasi
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
            PnlLogin = new Panel();
            btnLoginPage = new Button();
            label6 = new Label();
            tbPassword = new TextBox();
            btnRegis = new Button();
            lblDescLogin = new Label();
            tbUsername = new TextBox();
            lblUsername = new Label();
            lblTitleLogin = new Label();
            lblPassword = new Label();
            lblTipe = new Label();
            tbTipe = new TextBox();
            pictureBox1 = new PictureBox();
            PnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PnlLogin
            // 
            PnlLogin.BackColor = SystemColors.ButtonHighlight;
            PnlLogin.Controls.Add(btnLoginPage);
            PnlLogin.Controls.Add(label6);
            PnlLogin.Controls.Add(tbPassword);
            PnlLogin.Controls.Add(btnRegis);
            PnlLogin.Controls.Add(lblDescLogin);
            PnlLogin.Controls.Add(tbUsername);
            PnlLogin.Controls.Add(lblUsername);
            PnlLogin.Controls.Add(lblTitleLogin);
            PnlLogin.Controls.Add(lblPassword);
            PnlLogin.Controls.Add(lblTipe);
            PnlLogin.Controls.Add(tbTipe);
            PnlLogin.Location = new Point(668, 32);
            PnlLogin.Name = "PnlLogin";
            PnlLogin.Size = new Size(709, 880);
            PnlLogin.TabIndex = 13;
            // 
            // btnLoginPage
            // 
            btnLoginPage.BackColor = Color.Transparent;
            btnLoginPage.FlatAppearance.BorderSize = 0;
            btnLoginPage.FlatStyle = FlatStyle.Flat;
            btnLoginPage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoginPage.ForeColor = Color.DodgerBlue;
            btnLoginPage.Location = new Point(339, 797);
            btnLoginPage.Name = "btnLoginPage";
            btnLoginPage.Size = new Size(150, 46);
            btnLoginPage.TabIndex = 12;
            btnLoginPage.Text = "Masuk";
            btnLoginPage.TextAlign = ContentAlignment.MiddleLeft;
            btnLoginPage.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(48, 804);
            label6.Name = "label6";
            label6.Size = new Size(292, 32);
            label6.TabIndex = 11;
            label6.Text = "Kamu sudah punya Akun?";
            // 
            // tbPassword
            // 
            tbPassword.ForeColor = Color.DarkGray;
            tbPassword.Location = new Point(48, 549);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(604, 39);
            tbPassword.TabIndex = 9;
            tbPassword.Text = "e.g. Tes***345";
            // 
            // btnRegis
            // 
            btnRegis.BackColor = Color.DodgerBlue;
            btnRegis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegis.ForeColor = Color.White;
            btnRegis.Location = new Point(48, 674);
            btnRegis.Name = "btnRegis";
            btnRegis.Size = new Size(604, 74);
            btnRegis.TabIndex = 10;
            btnRegis.Text = "Daftar";
            btnRegis.UseVisualStyleBackColor = false;
            // 
            // lblDescLogin
            // 
            lblDescLogin.AutoSize = true;
            lblDescLogin.BackColor = Color.Transparent;
            lblDescLogin.ForeColor = Color.DimGray;
            lblDescLogin.Location = new Point(48, 139);
            lblDescLogin.Name = "lblDescLogin";
            lblDescLogin.Size = new Size(542, 32);
            lblDescLogin.TabIndex = 5;
            lblDescLogin.Text = "Selamat datang, ayo segera daftarkan akun Anda!";
            // 
            // tbUsername
            // 
            tbUsername.ForeColor = Color.DarkGray;
            tbUsername.Location = new Point(48, 413);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(604, 39);
            tbUsername.TabIndex = 7;
            tbUsername.Text = "e.g. Axel Zaki Ramadhan";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(48, 365);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(121, 32);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            // 
            // lblTitleLogin
            // 
            lblTitleLogin.AutoSize = true;
            lblTitleLogin.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleLogin.Location = new Point(206, 48);
            lblTitleLogin.Name = "lblTitleLogin";
            lblTitleLogin.Size = new Size(310, 72);
            lblTitleLogin.TabIndex = 0;
            lblTitleLogin.Text = "Dish4Good";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(48, 501);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(111, 32);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // lblTipe
            // 
            lblTipe.AutoSize = true;
            lblTipe.Location = new Point(48, 234);
            lblTipe.Name = "lblTipe";
            lblTipe.Size = new Size(60, 32);
            lblTipe.TabIndex = 1;
            lblTipe.Text = "Tipe";
            // 
            // tbTipe
            // 
            tbTipe.BackColor = Color.White;
            tbTipe.ForeColor = Color.DarkGray;
            tbTipe.Location = new Point(48, 282);
            tbTipe.Name = "tbTipe";
            tbTipe.Size = new Size(604, 39);
            tbTipe.TabIndex = 4;
            tbTipe.Text = "e.g. Penerima/Donatur";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DodgerBlue;
            pictureBox1.Location = new Point(38, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(598, 880);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // FormRegistrasi
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1414, 953);
            Controls.Add(pictureBox1);
            Controls.Add(PnlLogin);
            Name = "FormRegistrasi";
            Text = "Daftar Dish4Good";
            PnlLogin.ResumeLayout(false);
            PnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlLogin;
        private Button btnLoginPage;
        private Label label6;
        private TextBox tbPassword;
        private Button btnRegis;
        private Label lblDescLogin;
        private TextBox tbUsername;
        private Label lblUsername;
        private Label lblTitleLogin;
        private Label lblPassword;
        private Label lblTipe;
        private TextBox tbTipe;
        private PictureBox pictureBox1;
    }
}