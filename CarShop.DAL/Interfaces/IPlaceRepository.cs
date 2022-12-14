using CarShop.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.DAL.Interfaces
{
    public interface IPlaceRepository : IBaseRepository<Place>
    {
       Task<Place> GetByPlace(int carNum);

    }
}
