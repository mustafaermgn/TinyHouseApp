using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using TinyHouseApp.Helpers;

namespace TinyHouseApp.Forms
{
    public partial class CommentForm : Form
    {
        private int _renterId;

        public CommentForm(int renterId)
        {
            InitializeComponent();
            _renterId = renterId;
            LoadPendingComments();
        }

        private void LoadPendingComments()
        {
            var sql = @"
                SELECT 
                    r.ReservationID,
                    h.Title,
                    r.StartDate,
                    r.EndDate
                FROM Reservations r
                JOIN Houses h ON r.HouseID = h.HouseID
                WHERE 
                    r.RenterID = @rid
                    AND r.Status = 'Completed'
                    AND NOT EXISTS (
                        SELECT 1 FROM Comments c 
                        WHERE c.ReservationID = r.ReservationID 
                          AND c.RenterID = @rid
                    )";

            dgvReservations.DataSource = DBHelper.GetDataTable(
                sql,
                new SqlParameter("@rid", _renterId)
            );
        }

        private void btnAddComment_Click(object sender, EventArgs e)
        {
            if (dgvReservations.CurrentRow == null)
            {
                MessageBox.Show("Önce bir rezervasyon seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int reservationId = (int)dgvReservations.CurrentRow.Cells["ReservationID"].Value;
            int rating = (int)numRating.Value;
            string text = txtComment.Text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Lütfen yorum metni girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DBHelper.ExecuteNonQuery(
                    "sp_AddComment",
                    new SqlParameter("@ReservationID", reservationId),
                    new SqlParameter("@RenterID", _renterId),
                    new SqlParameter("@Rating", rating),
                    new SqlParameter("@CommentText", text)
                );

                MessageBox.Show("Yorumunuz kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPendingComments();
                txtComment.Clear();
                numRating.Value = 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
