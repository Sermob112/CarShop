using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarShop.Domain.ViewModels.Place
{
	public class PlaceViewModel
	{
        public int price { get; set; }
        public DateTime On { get; set; }
        public DateTime Off { get; set; }


    }
}
