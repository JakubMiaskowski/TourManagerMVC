using Microsoft.AspNetCore.Mvc;

namespace TourManagerMVC.Web.Controllers
{
    public class VenueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
