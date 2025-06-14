﻿using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using TinyHouseApp.Helpers;

namespace TinyHouseApp.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            LoadRoles();
        }

        private void LoadRoles()
        {
           
            var dt = DBHelper.GetDataTable("SELECT RoleID, RoleName FROM Roles WHERE RoleName <> 'Admin'");
            comboRole.DisplayMember = "RoleName";
            comboRole.ValueMember = "RoleID";
            comboRole.DataSource = dt;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            var first = txtFirstName.Text.Trim();
            var last = txtLastName.Text.Trim();
            var email = txtEmail.Text.Trim();
            var pass = txtPassword.Text.Trim();
            var role = (int)comboRole.SelectedValue;

            try
            {
               
                DBHelper.ExecuteNonQuery(@"
              INSERT INTO Users(FirstName, LastName, Email, Password, RoleID, IsActive)
              VALUES(@fn,@ln,@e,@p,@r,1)",
              CommandType.Text,
              new SqlParameter("@fn", first),
              new SqlParameter("@ln", last),
              new SqlParameter("@e", email),
              new SqlParameter("@p", pass),
              new SqlParameter("@r", role)
  );

                MessageBox.Show("Kayıt başarılı! Şimdi giriş yapabilirsiniz.",
                                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (SqlException ex)
            {
                
                if (ex.Number == 2627) 
                    MessageBox.Show("Bu e-posta adresi zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
