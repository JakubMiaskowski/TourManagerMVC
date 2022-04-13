using Microsoft.AspNetCore.Mvc;
using TourManagerMVC.Application.Interfaces;

namespace TourManagerMVC.Web.Controllers
{
    public class VenueController : Controller
    {
        private readonly IVenueService _venueService;

        public VenueController(IVenueService venueService)
        {
            _venueService = venueService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var venues = _venueService.GetAllVenues();
            return View(venues);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var venueDetails = _venueService.GetVenueDetails(id);
            return View(venueDetails);
        }

    }
}
