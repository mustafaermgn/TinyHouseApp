using System;

namespace TinyHouseApp.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int ReservationID { get; set; }
        public int RenterID { get; set; }
        public int Rating { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
    }
}
