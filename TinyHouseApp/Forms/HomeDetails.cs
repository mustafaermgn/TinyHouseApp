using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TinyHouseApp.Helpers;

namespace TinyHouseApp.Forms
{
    public partial class HomeDetails : Form
    {
        private int _houseId;
        private int ReservationID;
        public HomeDetails(int houseID)
        {
            InitializeComponent();
            _houseId = houseID;
            LoadReservaitons();
            dgwReservations.AutoGenerateColumns = true;

        }

        private void LoadReservaitons()
        {
            dgwReservations.AutoGenerateColumns = false;
            dgwReservations.DataSource = DBHelper.GetDataTable(
                "SELECT * FROM Reservations WHERE HouseID=@h",



                new SqlParameter("@h", _houseId)
            );
        }
        private void LoadComments(int ReservationID)
        {
            dgwComments.AutoGenerateColumns = false;
            int _reservationId = ReservationID;
            dgwComments.DataSource = DBHelper.GetDataTable(
                "SELECT * FROM Comments WHERE ReservationID=@r",
                new SqlParameter("@r", _reservationId)
            );
        }
        private void HomeDetails_Load(object sender, EventArgs e)
        {
            dgwReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwReservations.MultiSelect = false;
            dgwComments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwComments.MultiSelect = false;

            LoadReservaitons();
            dgwReservations.AutoGenerateColumns = true;

            //LoadHouseImages();
        }


        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (dgwReservations.CurrentRow == null)
            {
                MessageBox.Show("Lütfen onaylanacak bir rezervasyon seçin.");
                return;
            }


            var cellValue = dgwReservations.CurrentRow.Cells["reservationIDDataGridViewTextBoxColumn"].Value;
            if (cellValue == null || cellValue == DBNull.Value)
            {
                MessageBox.Show("Geçersiz rezervasyon ID.");
                return;
            }

            int reservationId = Convert.ToInt32(cellValue);
           

            try
            {
                int affectedRows = DBHelper.ExecuteNonQuery(
                    "UPDATE Reservations SET Status='Approved' WHERE ReservationID=@r",
                    CommandType.Text,
                    new SqlParameter("@r", reservationId)
                );

                if (affectedRows > 0)
                {
                    MessageBox.Show("Rezervasyon onaylandı.");
                    LoadReservaitons(); // Listeyi yenile
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);

            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (dgwReservations.CurrentRow == null)
            {
                MessageBox.Show("Lütfen reddedilecek bir rezervasyon seçin.");
                return;
            }

            try
            {
                int reservationId = Convert.ToInt32(dgwReservations.CurrentRow.Cells["reservationIDDataGridViewTextBoxColumn"].Value);

                int affectedRows = DBHelper.ExecuteNonQuery(
                    "UPDATE Reservations SET Status='Decline' WHERE ReservationID=@r",
                    CommandType.Text,
                    new SqlParameter("@r", reservationId)
                );

                if (affectedRows > 0)
                {
                    MessageBox.Show("Rezervasyon reddedildi.");
                    LoadReservaitons();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void btnComments_Click(object sender, EventArgs e)
        {
            if (dgwReservations.CurrentRow == null)
            {
                MessageBox.Show("Lütfen önce bir rezervasyon seçin.");
                return;
            }

            try
            {
                if (dgwReservations.CurrentRow.Cells["reservationIDDataGridViewTextBoxColumn"].Value != null)
                {
                    ReservationID = (int)dgwReservations.CurrentRow.Cells["reservationIDDataGridViewTextBoxColumn"].Value;
                    LoadComments(ReservationID);
                }
                else
                {
                    var columnNames = dgwReservations.Columns
                        .Cast<DataGridViewColumn>()
                        .Select(x => x.Name)
                        .ToList();

                    MessageBox.Show($"Rezervasyon ID sütunu bulunamadı. Mevcut sütunlar: {string.Join(", ", columnNames)}");
                }
            }
            catch (Exception ex)
            {
                var columnNames = dgwReservations.Columns
                        .Cast<DataGridViewColumn>()
                        .Select(x => x.Name)
                        .ToList();
                MessageBox.Show("Hata: " + ex.Message);
                MessageBox.Show($"Rezervasyon ID sütunu bulunamadı. Mevcut sütunlar: {string.Join(", ", columnNames)}");
            }
        }

     
    }
}
