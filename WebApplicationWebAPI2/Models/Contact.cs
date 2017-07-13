using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWebAPI2.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Contact()
        {
            Id = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
        }
    }
}