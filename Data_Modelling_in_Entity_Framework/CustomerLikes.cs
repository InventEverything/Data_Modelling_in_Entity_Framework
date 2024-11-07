using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Modelling_in_Entity_Framework
{
    internal class CustomerLikes
    {
        public int CustomerLikeId { get; set; }
        public int CustomerId { get; set; }
        public int LikeId { get; set; }
    }
}
