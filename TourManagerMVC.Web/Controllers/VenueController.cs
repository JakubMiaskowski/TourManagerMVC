using Microsoft.AspNetCore.Mvc;

namespace TourManagerMVC.Web.Controllers
{
    public class VenueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddVenue()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddVenue(int id)
        {
            return View();
        }
    }
}
