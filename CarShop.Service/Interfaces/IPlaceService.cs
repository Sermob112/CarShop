using CarShop.Domain.Entity;
using CarShop.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Service.Interfaces
{
    public interface IPlaceService
    {
      
        IBaseResponse<List<Place>> GetPlaces();
    }
}
