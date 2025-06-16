using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using TinyHouseApp.Helpers;

namespace TinyHouseApp.Forms
{
    public partial class RenterForm : Form
    {
        private int _renterId;
        public RenterForm(int renterId)
        {
            InitializeComponent();
            _renterId = renterId;
            LoadAvailableHouses();

        }

        private void LoadAvailableHouses()
        {
            dgvHousesAvail.DataSource = DBHelper.GetDataTable(
                "SELECT h.*, u.FirstName + ' ' + u.LastName AS OwnerName, dbo.fn_AvgRating(h.HouseID) AS AvgRating " +
                "FROM Houses h JOIN Users u ON h.OwnerID=u.UserID WHERE h.IsActive=1"
            );
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (dgvHousesAvail.CurrentRow == null) return;

            var dt = (DataTable)dgvHousesAvail.DataSource;
            var rowIndex = dgvHousesAvail.CurrentRow.Index;
            int houseId = Convert.ToInt32(dt.Rows[rowIndex]["HouseID"]);

            var form = new ReservationForm(houseId, _renterId);
            form.ShowDialog();
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            var form = new PaymentForm(_renterId);
            form.ShowDialog();
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            var form = new CommentForm(_renterId);
            form.ShowDialog();
        }

        private void dgvHousesAvail_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHousesAvail.CurrentRow == null) return;

            int houseId = Convert.ToInt32(dgvHousesAvail.CurrentRow.Cells["HouseID"].Value);
            var dt = DBHelper.GetHouseImages(houseId);
            if (dt.Rows.Count > 0)
            {
                string path = dt.Rows[0]["ImagePath"].ToString();
                if (File.Exists(path))
                {
                    pbHouseImage.Image = Image.FromFile(path);
                }
                else
                {
                    pbHouseImage.Image = null;
                }
            }
            else
            {
                pbHouseImage.Image = null;
            }
        }
    }
}
