using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Contacts_System.Models
{
    public class Contacts
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

    }
}