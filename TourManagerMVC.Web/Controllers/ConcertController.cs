using Microsoft.AspNetCore.Mvc;

namespace TourManagerMVC.Web.Controllers
{
    public class ConcertController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
