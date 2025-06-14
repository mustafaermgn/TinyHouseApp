using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using TinyHouseApp.Helpers;

namespace TinyHouseApp.Forms
{
    public partial class HostForm : Form
    {
        private int _ownerId; 
        private int _houseId; 

        public HostForm(int ownerId)
        {
            InitializeComponent();
            _ownerId = ownerId;

            LoadMyHouses();
        }

        private void LoadMyHouses()
        {
            dgvHouses.DataSource = DBHelper.GetDataTable(
                "SELECT * FROM Houses WHERE OwnerID=@o",
                new SqlParameter("@o", _ownerId)
            );
        }

        private void btnAddHouse_Click(object sender, EventArgs e)
        {
            var form = new HouseForm(_ownerId);
            form.ShowDialog();
            LoadMyHouses();
        }

        private void btnEditHouse_Click(object sender, EventArgs e)
        {
            if (dgvHouses.CurrentRow == null) return;
            var id = (int)dgvHouses.CurrentRow.Cells["HouseID"].Value;
            var form = new HouseForm(_ownerId, id);
            form.ShowDialog();
            LoadMyHouses();
        }

        private void btnDeleteHouse_Click(object sender, EventArgs e)
        {
            if (dgvHouses.CurrentRow == null) return;
            var id = (int)dgvHouses.CurrentRow.Cells["HouseID"].Value;
            DBHelper.ExecuteNonQuery("DELETE FROM Houses WHERE HouseID=@h", new SqlParameter("@h", id));
            LoadMyHouses();
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {

            _houseId = (int)dgvHouses.CurrentRow.Cells["HouseID"].Value;
            var form = new HomeDetails(_houseId);
            form.ShowDialog();
            LoadMyHouses();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
