using System;
using System.Collections.Generic;
using System.Text;

namespace MordyGolf.DataContracts
{
    public class BookingContract
    {
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public DateTime BookingDate { get; set; }
        public int NumberOfPlayers { get; set; }
        public int NumberOfCarts { get; set; }
    }
}
