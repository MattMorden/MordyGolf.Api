using System;
using System.Collections.Generic;
using System.Text;

namespace MordyGolf.DataContracts
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public Guid Identifier { get; set; }
        public int NumberOfPlayers { get; set; }
        public int NumberOfCarts { get; set; }
        public DateTime BookingDate { get; set; }
    }
}
