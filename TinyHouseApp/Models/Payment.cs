using System;

namespace TinyHouseApp.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public int ReservationID { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool IsPaid { get; set; }
    }
}
