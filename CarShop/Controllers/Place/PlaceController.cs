using CarShop.DAL;
using CarShop.DAL.Interfaces;
using CarShop.DAL.Repositories;
using Microsoft.AspNetCore.Mvc;
using CarShop.Domain.Entity;
namespace CarShop.Controllers.Place
{
    public class PlaceController : Controller
    {
       
        private readonly ICarRepository _carRepository;
        /* private readonly PlaceRepository _placeRepository;
         public PlaceController(PlaceRepository placeRepository)
         {
           _placeRepository = placeRepository; 
         }*/

        public PlaceController(ICarRepository placeRepository)
        {
            _carRepository = placeRepository;
        }
        [HttpGet]
        public  IActionResult GetPlaces()
        {
           
      /*      var repose1 = _carRepository.Get(2);*/
            var place = new CarShop.Domain.Entity.Place()
            {
                
                price = 129500
            };
         /*   var repose3 = _carRepository.Create(place);*/
            /*var repose2 = _carRepository.Delete(place);*/
            var reposedel =  _carRepository.Delete(19);
      /*      var reposedel1 = _carRepository.Delete(18);
            var reposedel2 = _carRepository.Delete(17);
            var reposedel3 = _carRepository.Delete(16);*/
            var repose =  _carRepository.GetAll();
            return View(repose);
        }
    }
}
