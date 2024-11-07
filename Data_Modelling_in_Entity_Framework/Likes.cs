using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Modelling_in_Entity_Framework
{
    internal class Likes
    {
        public int LikeId { get; set; }
        public string ThingLiked { get; set; }

        // collection of customers allows each like to have multiple customers associated with it
        public ICollection<Customers> CustomerId { get; set; }
    }
}
