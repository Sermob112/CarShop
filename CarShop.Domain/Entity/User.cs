using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Domain.Entity
{
    public class User
    {
        public string id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        /* public Role role { get; set; }*/

        public ICollection<Car> ViewCars { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
