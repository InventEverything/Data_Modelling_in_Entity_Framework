using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Modelling_in_Entity_Framework
{
    internal class Addresses
    {
        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string? Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        // collection allows each address to have multiple occupants
        public ICollection<Customers> Customers { get; set; } 
    }
}
