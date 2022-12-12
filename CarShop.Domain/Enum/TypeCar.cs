using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarShop.Domain.Enum
{
    public enum TypeCar
    {
        [Display(Name = "Легковой автомобиль")]
        PassengerCar = 0,
        [Display(Name = "Седан")]
        Sedan = 1,
        [Display(Name = "Хэтчбек")]
        HatchBack = 2,
        [Display(Name = "Спортивная машина")]
        SportCar = 3,
        [Display(Name = "Грузовой автомобиль")]
        HeavyCar = 4
    }
}
