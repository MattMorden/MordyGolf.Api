using System;
using System.Collections.Generic;
using System.Text;

namespace MordyGolf.DataContracts
{
    public class Course
    {
        public int CourseId { get; set; }
        public int ScoreCardId { get; set; }
        public string CourseName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime FirstTeeTime { get; set; }
        public DateTime LastTeeTime { get; set; }
        public string Website { get; set; }
    }
}
