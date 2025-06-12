using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using TinyHouseApp.Helpers;

namespace TinyHouseApp.Forms
{
    public partial class PaymentForm : Form
    {
        private int _renterId;

        public PaymentForm(int renterId)
        {
            InitializeComponent();
            _renterId = renterId;
            LoadPendingReservations();
        }

        private void LoadPendingReservations()
        {
           
            var sql = @"
                SELECT r.ReservationID,
                       h.Title,
                       r.StartDate,
                       r.EndDate,
                       DATEDIFF(day, r.StartDate, r.EndDate) * h.PricePerNight AS TotalAmount
                FROM Reservations r
                JOIN Houses h ON r.HouseID = h.HouseID
                WHERE r.RenterID = @rid
                  AND r.Status = 'Approved'
                  AND r.PaymentStatus = 'Unpaid'";

            dgvReservations.DataSource = DBHelper.GetDataTable(
                sql,
                new SqlParameter("@rid", _renterId)
            );
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dgvReservations.CurrentRow == null)
            {
                MessageBox.Show("Önce bir rezervasyon seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var reservationId = (int)dgvReservations.CurrentRow.Cells["ReservationID"].Value;
                var amount = (decimal)dgvReservations.CurrentRow.Cells["TotalAmount"].Value;

                // Ödeme işlemi
                int result = DBHelper.ExecuteNonQuery(
                    "INSERT INTO Payments(ReservationID, Amount, IsPaid) VALUES(@rid,@amt,1)",
                    CommandType.Text, // Açıkça CommandType.Text belirtiyoruz
                    new SqlParameter("@rid", reservationId),
                    new SqlParameter("@amt", amount)
                );

                // Rezervasyon durumunu güncelle
                if (result > 0)
                {
                    DBHelper.ExecuteNonQuery(
                        "UPDATE Reservations SET PaymentStatus = 'Paid' WHERE ReservationID = @rid",
                        CommandType.Text,
                        new SqlParameter("@rid", reservationId)
                    );

                    MessageBox.Show("Ödeme başarılı, rezervasyon onaylandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPendingReservations();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ödeme işlemi sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmeyen hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
