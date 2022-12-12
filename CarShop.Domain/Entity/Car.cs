using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarShop.Domain.Enum;

namespace CarShop.Domain.Entity
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string userId { get; set; }
        public TypeCar mark { get; set; }
        public string carNum { get; set; }

        public virtual User users { get; set; }

    }
}
