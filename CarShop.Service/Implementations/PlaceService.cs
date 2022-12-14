using CarShop.DAL.Interfaces;
using CarShop.Domain.Entity;
using CarShop.Domain.Enum;
using CarShop.Domain.Response;
using CarShop.Service.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IBaseResponse<bool>> DeleteById(int id)
        {
            try
            {
                var car = await placeRepository.GetAll().FirstOrDefaultAsync(x => x.id == id);
                if (car == null)
                {
                    return new BaseResponse<bool>()
                    {
                        Description = "Place not found",
                        StatusCode = StatusCode.PlaceNotFound,
                        Data = false
                    };
                }

                await placeRepository.Delete(car);

                return new BaseResponse<bool>()
                {
                    Data = true,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<bool>()
                {
                    Description = $"[DeleteById] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }

        public IBaseResponse<Place> GetPlaceById(int id)
        {
            throw new NotImplementedException();
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
