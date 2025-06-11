using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using TinyHouseApp.Helpers;

namespace TinyHouseApp.Forms
{
    public partial class ReservationForm : Form
    {
        private int _houseId, _renterId;
        public ReservationForm(int houseId, int renterId)
        {
            InitializeComponent();
            _houseId = houseId;
            _renterId = renterId;
          
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            var sd = dtpStart.Value.Date;
            var ed = dtpEnd.Value.Date;
            try
            {
                DBHelper.ExecuteNonQuery("sp_CreateReservation",
                    new SqlParameter("@HouseID", _houseId),
                    new SqlParameter("@RenterID", _renterId),
                    new SqlParameter("@StartDate", sd),
                    new SqlParameter("@EndDate", ed)
                );
                MessageBox.Show("Rezervasyon yapıldı, onay bekleniyor.");
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
