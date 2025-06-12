using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
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
                // Parametre değerlerini kontrol et
                if (_houseId <= 0 || _renterId <= 0)
                {
                    MessageBox.Show("Geçersiz ev veya kullanıcı bilgisi");
                    return;
                }

                // Debug bilgisi
                Console.WriteLine($"HouseID: {_houseId}, RenterID: {_renterId}, Start: {sd}, End: {ed}");

                int result = DBHelper.ExecuteNonQuery("sp_CreateReservation",
                    CommandType.StoredProcedure, // Açıkça belirt
                    new SqlParameter("@HouseID", _houseId),
                    new SqlParameter("@RenterID", _renterId),
                    new SqlParameter("@StartDate", sd),
                    new SqlParameter("@EndDate", ed)
                );

                if (result > 0)
                {
                    MessageBox.Show("Rezervasyon yapıldı, onay bekleniyor.");
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Rezervasyon hatası: {ex.Message}\n\nDetay: {ex.InnerException?.Message}",
                              "Hata",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmeyen hata: {ex.Message}",
                              "Hata",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }
        private void ReservationForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
