namespace TinyHouseApp.Forms
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblRole = new Label();
            comboRole = new ComboBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(223, 123);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(29, 19);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "Ad:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(303, 120);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(300, 25);
            txtFirstName.TabIndex = 0;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(223, 168);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(49, 19);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Soyad:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(303, 165);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(300, 25);
            txtLastName.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(223, 213);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 19);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-posta:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(303, 210);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 25);
            txtEmail.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(223, 258);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(38, 19);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Şifre:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(303, 255);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(300, 25);
            txtPassword.TabIndex = 3;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(223, 303);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(31, 19);
            lblRole.TabIndex = 4;
            lblRole.Text = "Rol:";
            // 
            // comboRole
            // 
            comboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRole.Items.AddRange(new object[] { "Kullanıcı", "Yönetici" });
            comboRole.Location = new Point(303, 300);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(300, 25);
            comboRole.TabIndex = 4;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(40, 167, 69);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(303, 353);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(300, 35);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(894, 537);
            Controls.Add(lblFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblRole);
            Controls.Add(comboRole);
            Controls.Add(btnRegister);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt Ol";
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
