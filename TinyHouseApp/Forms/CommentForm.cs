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
                    AND r.Status = 'Approved'
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
                MessageBox.Show("Lütfen bir rezervasyon seçin");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtComment.Text))
            {
                MessageBox.Show("Yorum metni boş olamaz");
                return;
            }

            try
            {
                int reservationId = Convert.ToInt32(dgvReservations.CurrentRow.Cells["ReservationID"].Value);
                int rating = (int)numRating.Value; 

                int result = DBHelper.AddComment(
                    reservationId,
                    txtComment.Text.Trim(),
                    _renterId,
                    rating
                );

                if (result > 0)
                {
                    MessageBox.Show("Yorum ve puan başarıyla eklendi");
                    txtComment.Clear();
                    LoadPendingComments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yorum eklenirken hata oluştu: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
