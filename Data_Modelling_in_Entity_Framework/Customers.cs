using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Modelling_in_Entity_Framework
{
    internal class Customers
    {
        [NotNull]
        public int CustomerId { get; set; }                         // single unique,                           not nullable

        [NotNull]
        public string FirstName { get; set; }                       // single,                                  not nullable

        [AllowNull]
        public string MiddleName { get; set; }                      // single,                                      nullable

        [NotNull]
        public string LastName { get; set; }                        // single,                                  not nullable

        [NotNull]
        public DateOnly Birthday { get; set; }                      // single,                                  not nullable

        [AllowNull]
        public string Email { get; set; }                           // single,                                      nullable


        // collection allows a each customer to have multiple phone numbers
        [AllowNull]
        public ICollection<PhoneNumbers> PhoneNumber { get; set; }  // one customer can have many phone numbers,    nullable

        // each customer has an address
        [AllowNull]
        public Addresses Address { get; set; }                      // many customers can live at one address,      nullable

        // collection allows a each customer to have multiple likes
        [AllowNull]
        public ICollection<CustomerLikes> Likes { get; set; }               // many customers can have many likes,          nullable
    }
}
