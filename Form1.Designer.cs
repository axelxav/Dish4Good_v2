namespace Dish4Good_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitleLogin = new Label();
            lblDescLogin = new Label();
            tbUsername = new TextBox();
            lblUsername = new Label();
            tbPassword = new TextBox();
            lblPassword = new Label();
            btnLogin = new Button();
            PnlLogin = new Panel();
            btnRegisPage = new Button();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            PnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            // lblDescLogin
            // 
            lblDescLogin.AutoSize = true;
            lblDescLogin.BackColor = Color.Transparent;
            lblDescLogin.ForeColor = Color.DimGray;
            lblDescLogin.Location = new Point(49, 139);
            lblDescLogin.Name = "lblDescLogin";
            lblDescLogin.Size = new Size(578, 32);
            lblDescLogin.TabIndex = 5;
            lblDescLogin.Text = "Selamat datang kembali! ayo segera masuk sekarang";
            // 
            // tbUsername
            // 
            tbUsername.ForeColor = Color.Black;
            tbUsername.Location = new Point(49, 318);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(604, 39);
            tbUsername.TabIndex = 7;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(49, 270);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(121, 32);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            // 
            // tbPassword
            // 
            tbPassword.ForeColor = Color.Black;
            tbPassword.Location = new Point(49, 454);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(604, 39);
            tbPassword.TabIndex = 9;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(49, 406);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(111, 32);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(49, 674);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(604, 74);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Masuk";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // PnlLogin
            // 
            PnlLogin.BackColor = SystemColors.ButtonHighlight;
            PnlLogin.Controls.Add(btnRegisPage);
            PnlLogin.Controls.Add(label6);
            PnlLogin.Controls.Add(tbPassword);
            PnlLogin.Controls.Add(btnLogin);
            PnlLogin.Controls.Add(lblDescLogin);
            PnlLogin.Controls.Add(tbUsername);
            PnlLogin.Controls.Add(lblUsername);
            PnlLogin.Controls.Add(lblTitleLogin);
            PnlLogin.Controls.Add(lblPassword);
            PnlLogin.Location = new Point(668, 32);
            PnlLogin.Name = "PnlLogin";
            PnlLogin.Size = new Size(708, 880);
            PnlLogin.TabIndex = 12;
            // 
            // btnRegisPage
            // 
            btnRegisPage.BackColor = Color.Transparent;
            btnRegisPage.FlatAppearance.BorderSize = 0;
            btnRegisPage.FlatStyle = FlatStyle.Flat;
            btnRegisPage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegisPage.ForeColor = Color.DodgerBlue;
            btnRegisPage.Location = new Point(340, 797);
            btnRegisPage.Name = "btnRegisPage";
            btnRegisPage.Size = new Size(150, 46);
            btnRegisPage.TabIndex = 12;
            btnRegisPage.Text = "Daftar";
            btnRegisPage.TextAlign = ContentAlignment.MiddleLeft;
            btnRegisPage.UseVisualStyleBackColor = false;
            btnRegisPage.Click += btnRegisPage_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.DimGray;
            label6.Location = new Point(49, 803);
            label6.Name = "label6";
            label6.Size = new Size(296, 32);
            label6.TabIndex = 11;
            label6.Text = "Kamu belum punya Akun?";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DodgerBlue;
            pictureBox1.Image = Properties.Resources.Illustration_Dish4Good;
            pictureBox1.Location = new Point(37, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(598, 880);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1414, 954);
            Controls.Add(pictureBox1);
            Controls.Add(PnlLogin);
            Name = "Form1";
            Text = "Login Dish4Good";
            PnlLogin.ResumeLayout(false);
            PnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitleLogin;
        private Label lblDescLogin;
        private TextBox tbUsername;
        private Label lblUsername;
        private TextBox tbPassword;
        private Label lblPassword;
        private Button btnLogin;
        private Panel PnlLogin;
        private Button btnRegisPage;
        private Label label6;
        private PictureBox pictureBox1;
    }
}