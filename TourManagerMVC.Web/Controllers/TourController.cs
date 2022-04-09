using Microsoft.AspNetCore.Mvc;

namespace TourManagerMVC.Web.Controllers
{
    public class TourController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
