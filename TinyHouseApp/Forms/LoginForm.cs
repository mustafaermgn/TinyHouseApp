using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using TinyHouseApp.Helpers;

namespace TinyHouseApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoadRoles();
        }

        private void LoadRoles()
        {
            var dt = DBHelper.GetDataTable("SELECT * FROM Roles");
            comboRole.DisplayMember = "RoleName";
            comboRole.ValueMember = "RoleID";
            comboRole.DataSource = dt;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text.Trim();
            var pass = txtPassword.Text.Trim();
            var roleId = (int)comboRole.SelectedValue;

            var dt = DBHelper.GetDataTable(
                "SELECT * FROM Users WHERE Email=@e AND Password=@p AND RoleID=@r AND IsActive=1",
                new SqlParameter("@e", email),
                new SqlParameter("@p", pass),
                new SqlParameter("@r", roleId)
            );

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Kullanıcı bulunamadı veya yetki hatası.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            int userId = (int)dt.Rows[0]["UserID"];

            this.Hide();
            switch (roleId)
            {
                case 1:
                    new AdminForm().Show();
                    break;
                case 2: 
                    new HostForm(userId).Show();
                    break;
                case 3: 
                    new RenterForm(userId).Show();
                    break;
                default:
                    MessageBox.Show("Tanımsız rol!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Show();
                    break;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using var regForm = new RegisterForm();
            regForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
