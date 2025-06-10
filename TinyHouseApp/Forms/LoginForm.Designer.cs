namespace TinyHouseApp.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister; // Yeni eklenen

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblRole = new Label();
            comboRole = new ComboBox();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(261, 163);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 19);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(361, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 25);
            txtEmail.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(261, 208);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(38, 19);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Şifre:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(361, 205);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(220, 25);
            txtPassword.TabIndex = 1;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(261, 253);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(31, 19);
            lblRole.TabIndex = 2;
            lblRole.Text = "Rol:";
            // 
            // comboRole
            // 
            comboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRole.Items.AddRange(new object[] { "Kullanıcı", "Yönetici" });
            comboRole.Location = new Point(361, 250);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(220, 25);
            comboRole.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 123, 255);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(361, 298);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 35);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(40, 167, 69);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(481, 298);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 35);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(895, 536);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblRole);
            Controls.Add(comboRole);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
