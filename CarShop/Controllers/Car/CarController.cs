using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers
{
    public class CarController : Controller
    {
        public IActionResult GetCars()
        {
            return View();
        }
    }
}
