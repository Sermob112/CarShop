using CarShop.Domain.Entity;
using CarShop.Domain.Response;
using CarShop.Domain.ViewModels.Place;
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
        Task<IBaseResponse<PlaceViewModel>> GetPlaceById(int id);
        Task<IBaseResponse<bool>> DeleteById(int id);

        Task<IBaseResponse<Place>> Create(PlaceViewModel place);
    }
}
