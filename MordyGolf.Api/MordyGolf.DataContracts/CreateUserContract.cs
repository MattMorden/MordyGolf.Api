using System;
using System.Collections.Generic;
using System.Text;

namespace MordyGolf.DataContracts
{
    public class CreateUserContract
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string EmailAddress { get; set; }
        public int PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}
