using CarShop.DAL;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Controllers.Place
{
    public class PlaceController : Controller
    {
        ApplicationDbContext applicationDB;
        public IActionResult Index()
        {
            return View();
        }
    }
}
