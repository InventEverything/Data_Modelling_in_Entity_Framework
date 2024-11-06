using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Modelling_in_Entity_Framework
{
    internal class Customers
    {
        public int CustomerId { get; set; }     // single unique,                           not nullable
        public string FirstName { get; set; }   // single,                                  not nullable
        public string MiddleName { get; set; }  // single,                                      nullable
        public string LastName { get; set; }    // single,                                  not nullable
        public DateOnly Birthday { get; set; }  // single,                                  not nullable

        public string PhoneNumbers { get; set; } // one customer can have many phone numbers,   nullable
        public string Address { get; set; }     // many customers can live at one address,      nullable
        public string Email { get; set; }       // single,                                      nullable
        public string Likes { get; set; }       // many customers can have many likes,          nullable
    }
}
