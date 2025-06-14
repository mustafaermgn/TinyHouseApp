using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TinyHouseApp.Helpers;

namespace TinyHouseApp.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            LoadAllTabs();
        }

        private void LoadAllTabs()
        {
           
            dgvRoles.DataSource = DBHelper.GetDataTable("SELECT * FROM Roles");
            dgvUsers.DataSource = DBHelper.GetDataTable("SELECT u.UserID, u.FirstName, u.LastName, u.Email, r.RoleName, u.IsActive FROM Users u JOIN Roles r ON u.RoleID=r.RoleID");
            dgvHouses.DataSource = DBHelper.GetDataTable("SELECT * FROM Houses");
            dgvReservations.DataSource = DBHelper.GetDataTable("SELECT * FROM Reservations");
            dgvComments.DataSource = DBHelper.GetDataTable("SELECT * FROM Comments");
        }

      
        private void btnAddRole_Click(object sender, EventArgs e)
        {
            var name = txtRoleName.Text.Trim();
            if (string.IsNullOrEmpty(name)) return;
            DBHelper.ExecuteNonQuery("INSERT INTO Roles(RoleName) VALUES(@n)", new SqlParameter("@n", name));
            LoadAllTabs();
        }
    }
}
