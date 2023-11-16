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
            cmbRole = new ComboBox();
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
            pictureBox1 = new PictureBox();
            PnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PnlLogin
            // 
            PnlLogin.BackColor = SystemColors.ButtonHighlight;
            PnlLogin.Controls.Add(cmbRole);
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
            PnlLogin.Location = new Point(411, 20);
            PnlLogin.Margin = new Padding(2);
            PnlLogin.Name = "PnlLogin";
            PnlLogin.Size = new Size(436, 550);
            PnlLogin.TabIndex = 13;
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.ForeColor = SystemColors.InfoText;
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(30, 169);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(373, 28);
            cmbRole.TabIndex = 13;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // btnLoginPage
            // 
            btnLoginPage.BackColor = Color.Transparent;
            btnLoginPage.FlatAppearance.BorderSize = 0;
            btnLoginPage.FlatStyle = FlatStyle.Flat;
            btnLoginPage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoginPage.ForeColor = Color.DodgerBlue;
            btnLoginPage.Location = new Point(209, 498);
            btnLoginPage.Margin = new Padding(2);
            btnLoginPage.Name = "btnLoginPage";
            btnLoginPage.Size = new Size(92, 29);
            btnLoginPage.TabIndex = 12;
            btnLoginPage.Text = "Masuk";
            btnLoginPage.TextAlign = ContentAlignment.MiddleLeft;
            btnLoginPage.UseVisualStyleBackColor = false;
            btnLoginPage.Click += btnLoginPage_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(30, 502);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(178, 20);
            label6.TabIndex = 11;
            label6.Text = "Kamu sudah punya Akun?";
            // 
            // tbPassword
            // 
            tbPassword.ForeColor = Color.Black;
            tbPassword.Location = new Point(30, 343);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(373, 27);
            tbPassword.TabIndex = 9;
            // 
            // btnRegis
            // 
            btnRegis.BackColor = Color.DodgerBlue;
            btnRegis.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegis.ForeColor = Color.White;
            btnRegis.Location = new Point(30, 421);
            btnRegis.Margin = new Padding(2);
            btnRegis.Name = "btnRegis";
            btnRegis.Size = new Size(372, 46);
            btnRegis.TabIndex = 10;
            btnRegis.Text = "Daftar";
            btnRegis.UseVisualStyleBackColor = false;
            btnRegis.Click += btnRegis_Click_1;
            // 
            // lblDescLogin
            // 
            lblDescLogin.AutoSize = true;
            lblDescLogin.BackColor = Color.Transparent;
            lblDescLogin.ForeColor = Color.DimGray;
            lblDescLogin.Location = new Point(30, 87);
            lblDescLogin.Margin = new Padding(2, 0, 2, 0);
            lblDescLogin.Name = "lblDescLogin";
            lblDescLogin.Size = new Size(338, 20);
            lblDescLogin.TabIndex = 5;
            lblDescLogin.Text = "Selamat datang, ayo segera daftarkan akun Anda!";
            // 
            // tbUsername
            // 
            tbUsername.ForeColor = Color.Black;
            tbUsername.Location = new Point(30, 258);
            tbUsername.Margin = new Padding(2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(373, 27);
            tbUsername.TabIndex = 7;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(30, 228);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            // 
            // lblTitleLogin
            // 
            lblTitleLogin.AutoSize = true;
            lblTitleLogin.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleLogin.Location = new Point(127, 30);
            lblTitleLogin.Margin = new Padding(2, 0, 2, 0);
            lblTitleLogin.Name = "lblTitleLogin";
            lblTitleLogin.Size = new Size(197, 46);
            lblTitleLogin.TabIndex = 0;
            lblTitleLogin.Text = "Dish4Good";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(30, 313);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // lblTipe
            // 
            lblTipe.AutoSize = true;
            lblTipe.Location = new Point(30, 146);
            lblTipe.Margin = new Padding(2, 0, 2, 0);
            lblTipe.Name = "lblTipe";
            lblTipe.Size = new Size(38, 20);
            lblTipe.TabIndex = 1;
            lblTipe.Text = "Tipe";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DodgerBlue;
            pictureBox1.Image = Properties.Resources.Illus_good;
            pictureBox1.Location = new Point(23, 20);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 550);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // FormRegistrasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(870, 596);
            Controls.Add(pictureBox1);
            Controls.Add(PnlLogin);
            Margin = new Padding(2);
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
        private PictureBox pictureBox1;
        private ComboBox cmbRole;
    }
}