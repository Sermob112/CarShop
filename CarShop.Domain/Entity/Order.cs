using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Domain.Entity
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int userId { get; set; }
        public int placeId { get; set; }
        public int carId { get; set; }
        public System.DateTime ON { get; set; }
        public System.DateTime Off { get; set; }
        public int quantity { get; set; }
        public string carNum { get; set; }
        public virtual Car cars { get; set; }
        public virtual Place place { get; set; }
        public virtual User users { get; set; }
    }
}
