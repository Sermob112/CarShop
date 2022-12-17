using CarShop.DAL.Interfaces;
using CarShop.Domain.Entity;
using CarShop.Domain.Enum;
using CarShop.Domain.Response;
using CarShop.Domain.ViewModels.Place;
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

        public async Task<IBaseResponse<Place>> Create(PlaceViewModel model)
        {
            try
            {
                var place = new Place()
                {
                   price = model.price
                   
                };
                await placeRepository.Create(place);

                return new BaseResponse<Place>()
                {
                    StatusCode = StatusCode.OK,
                    Data = place
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<Place>()
                {
                    Description = $"[Create] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
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

        public async Task<IBaseResponse<PlaceViewModel>> GetPlaceById(int id)
        {
            try
            {
                var place = await placeRepository.GetAll().FirstOrDefaultAsync(x => x.id == id);
                if (place == null)
                {
                    return new BaseResponse<PlaceViewModel>()
                    {
                        Description = "Пользователь не найден",
                        StatusCode = StatusCode.UserNotFound
                    };
                }

                var data = new PlaceViewModel()
                {
                id = place.id,
                price = place.price

                };

                return new BaseResponse<PlaceViewModel>()
                {
                    StatusCode = StatusCode.OK,
                    Data = data
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<PlaceViewModel>()
                {
                    Description = $"[GetPlaceById] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }

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
                    Description = $"[GetPlaces] : {ex.Message}",
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
    }
}
