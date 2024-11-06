using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Modelling_in_Entity_Framework
{
    internal class Customers
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateOnly Birthday { get; set; }
        public string PhoneNumbers { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Likes { get; set; }

    }
}
