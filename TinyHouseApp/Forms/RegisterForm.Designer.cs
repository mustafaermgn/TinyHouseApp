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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(223, 139);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(35, 23);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "Ad:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(303, 136);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(300, 30);
            txtFirstName.TabIndex = 0;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(223, 192);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(60, 23);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Soyad:";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(303, 189);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(300, 30);
            txtLastName.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(223, 238);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(72, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-posta:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(303, 238);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 30);
            txtEmail.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(223, 288);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(47, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Şifre:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(303, 288);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(300, 30);
            txtPassword.TabIndex = 3;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(223, 338);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(38, 23);
            lblRole.TabIndex = 4;
            lblRole.Text = "Rol:";
            // 
            // comboRole
            // 
            comboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRole.Items.AddRange(new object[] { "Kullanıcı", "Yönetici" });
            comboRole.Location = new Point(303, 338);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(300, 31);
            comboRole.TabIndex = 4;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(40, 167, 69);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(303, 388);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(300, 35);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-292, -376);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2560, 1709);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Lucida Console", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(101, 43);
            label1.Name = "label1";
            label1.Size = new Size(735, 34);
            label1.TabIndex = 7;
            label1.Text = "HEMEN KAYIT OL! SEN DE ARAMIZA KATIL";
            label1.Click += label1_Click;
            // 
            // RegisterForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(894, 537);
            Controls.Add(label1);
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
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayıt Ol";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox pictureBox1;
        private Label label1;
    }
}
