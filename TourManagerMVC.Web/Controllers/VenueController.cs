using Microsoft.AspNetCore.Mvc;
using TourManagerMVC.Application.Interfaces;
using TourManagerMVC.Application.ViewModels.Venue;

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
            var venues = _venueService.GetAllVenues(3, 1, "");
            return View(venues);
        }

        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo, string searchString)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }

            if (searchString is null)
            {
                searchString = string.Empty;
            }

            var venues = _venueService.GetAllVenues(pageSize, pageNo.Value, searchString);

            return View(venues);
        }

        [HttpGet]
        public IActionResult AddVenue()
        {
            return View(new NewVenueVm());
        }

        [HttpPost]
        public IActionResult AddVenue(NewVenueVm model)
        {
            var id = _venueService.AddVenue(model);
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var venueDetails = _venueService.GetVenueDetails(id);
            return View(venueDetails);
        }

    }
}
