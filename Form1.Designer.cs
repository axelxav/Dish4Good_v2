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
            lblTitleLogin.Location = new Point(127, 30);
            lblTitleLogin.Margin = new Padding(2, 0, 2, 0);
            lblTitleLogin.Name = "lblTitleLogin";
            lblTitleLogin.Size = new Size(197, 46);
            lblTitleLogin.TabIndex = 0;
            lblTitleLogin.Text = "Dish4Good";
            // 
            // lblDescLogin
            // 
            lblDescLogin.AutoSize = true;
            lblDescLogin.BackColor = Color.Transparent;
            lblDescLogin.ForeColor = Color.DimGray;
            lblDescLogin.Location = new Point(30, 87);
            lblDescLogin.Margin = new Padding(2, 0, 2, 0);
            lblDescLogin.Name = "lblDescLogin";
            lblDescLogin.Size = new Size(360, 20);
            lblDescLogin.TabIndex = 5;
            lblDescLogin.Text = "Selamat datang kembali! ayo segera masuk sekarang";
            // 
            // tbUsername
            // 
            tbUsername.ForeColor = Color.Black;
            tbUsername.Location = new Point(30, 199);
            tbUsername.Margin = new Padding(2, 2, 2, 2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(373, 27);
            tbUsername.TabIndex = 7;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(30, 169);
            lblUsername.Margin = new Padding(2, 0, 2, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username";
            // 
            // tbPassword
            // 
            tbPassword.ForeColor = Color.Black;
            tbPassword.Location = new Point(30, 284);
            tbPassword.Margin = new Padding(2, 2, 2, 2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(373, 27);
            tbPassword.TabIndex = 9;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(30, 254);
            lblPassword.Margin = new Padding(2, 0, 2, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(30, 421);
            btnLogin.Margin = new Padding(2, 2, 2, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(372, 46);
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
            PnlLogin.Location = new Point(411, 20);
            PnlLogin.Margin = new Padding(2, 2, 2, 2);
            PnlLogin.Name = "PnlLogin";
            PnlLogin.Size = new Size(436, 550);
            PnlLogin.TabIndex = 12;
            // 
            // btnRegisPage
            // 
            btnRegisPage.BackColor = Color.Transparent;
            btnRegisPage.FlatAppearance.BorderSize = 0;
            btnRegisPage.FlatStyle = FlatStyle.Flat;
            btnRegisPage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegisPage.ForeColor = Color.DodgerBlue;
            btnRegisPage.Location = new Point(209, 498);
            btnRegisPage.Margin = new Padding(2, 2, 2, 2);
            btnRegisPage.Name = "btnRegisPage";
            btnRegisPage.Size = new Size(92, 29);
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
            label6.Location = new Point(30, 502);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(181, 20);
            label6.TabIndex = 11;
            label6.Text = "Kamu belum punya Akun?";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DodgerBlue;
            pictureBox1.Image = Properties.Resources.Illustration_Dish4Good;
            pictureBox1.Location = new Point(23, 20);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 550);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(870, 596);
            Controls.Add(pictureBox1);
            Controls.Add(PnlLogin);
            Margin = new Padding(2, 2, 2, 2);
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