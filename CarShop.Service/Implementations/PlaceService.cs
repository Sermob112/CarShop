using CarShop.DAL.Interfaces;
using CarShop.Domain.Entity;
using CarShop.Domain.Enum;
using CarShop.Domain.Response;
using CarShop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Service.Implementations
{
    public class PlaceService : IPlaceService
    {
        private readonly IBaseRepository<Place> placeRepository;

        public PlaceService(IBaseRepository<Place> carRepository)
        {
            this.placeRepository = carRepository;
        }

        public IBaseResponse<List<Place>> GetPlaces()
        {
            try
            {
                var place = placeRepository.GetAll().ToList();
                if (!place.Any())
                {
                    return new BaseResponse<List<Place>>()
                    {
                        Description = "Найдено 0 элементов",
                        StatusCode = StatusCode.OK
                    };
                }

                return new BaseResponse<List<Place>>()
                {
                    Data = place,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<List<Place>>()
                {
                    Description = $"[GetCars] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
