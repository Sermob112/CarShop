using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Domain.Entity
{

    public class User
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public Profile Profile { get; set; }
   /*     public Basket Basket { get; set; }*/
        public ICollection<Car> Cars { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
