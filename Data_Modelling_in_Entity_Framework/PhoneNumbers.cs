using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Modelling_in_Entity_Framework
{
    internal class PhoneNumbers
    {
        public int PhoneId { get; set; }
        public string PhoneNumber { get; set; }
        public string Type { get; set; }

        // each phone number has only one customer with that number
        public Customers CustomerId { get; set; }
    }
}
