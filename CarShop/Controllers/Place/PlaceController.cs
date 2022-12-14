using CarShop.DAL;
using CarShop.DAL.Interfaces;
using CarShop.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using CarShop.Domain.Entity;
using CarShop.Service.Interfaces;

namespace CarShop.Controllers.Place
{
    public class PlaceController : Controller
    {
       
        private readonly IPlaceService placeService;
        /* private readonly PlaceRepository _placeRepository;
         public PlaceController(PlaceRepository placeRepository)
         {
           _placeRepository = placeRepository; 
         }*/

        public PlaceController(IPlaceService placeService)
        {
            this.placeService = placeService;
        }
        [HttpGet]
        public   IActionResult GetPlaces()
        {
            
            var response = placeService.GetPlaces();
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return View("Error", $"{response.Description}");
        }
    }
}
