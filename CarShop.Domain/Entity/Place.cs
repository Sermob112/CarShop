using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Domain.Entity
{
    public class Place
    {


        public int id { get; set; }
        public int price { get; set; }
        public DateTime On { get; set; }
        public DateTime Off { get; set; }


        public virtual ICollection<Order> orders { get; set; }
    }
}
