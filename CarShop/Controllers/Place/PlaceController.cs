using CarShop.DAL;
using CarShop.DAL.Interfaces;
using CarShop.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using CarShop.Domain.Entity;
using CarShop.Service.Interfaces;
using CarShop.Domain.ViewModels.Place;

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

        public async Task<IActionResult> Delete(int id)
        {
            var response = await placeService.DeleteById(id);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return RedirectToAction("GetCars");
            }
            return View("Error", $"{response.Description}");
        }

        [HttpGet]
        public async Task<IActionResult> Save(int id)
        {
            if (id == 0)
                return PartialView();

            var response = await placeService.GetPlaceById(id);
            if (response.StatusCode == Domain.Enum.StatusCode.OK)
            {
                return PartialView(response.Data);
            }
            ModelState.AddModelError("", response.Description);
            return PartialView();
        }

        // string Name, string Model, double Speed, string Description, decimal Price, string TypeCar, IFormFile Avatar
        [HttpPost]
        public async Task<IActionResult> Save(PlaceViewModel model)
        {
            ModelState.Remove("DateCreate");
            if (ModelState.IsValid)
            {
                if (model.id == 0)
                {
                   
                    await placeService.Create(model);
                }
               
            }
            return View();
        }

    }
}
