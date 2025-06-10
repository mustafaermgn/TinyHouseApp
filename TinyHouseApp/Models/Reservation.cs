using System;

namespace TinyHouseApp.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; }
        public int HouseID { get; set; }
        public int RenterID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public string PaymentStatus { get; set; }
    }
}
