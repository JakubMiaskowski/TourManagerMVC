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
            var venues = _venueService.GetAllVenues(1, 1, "");
            return View(venues);
        }

        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo, string searchString)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }

            if (searchString == null)
            {
                searchString = string.Empty;
            }

            var venues = _venueService.GetAllVenues(pageSize, pageNo, searchString);

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
