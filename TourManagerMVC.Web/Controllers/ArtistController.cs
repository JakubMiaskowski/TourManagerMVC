using Microsoft.AspNetCore.Mvc;
using TourManagerMVC.Application.Interfaces;
using TourManagerMVC.Domain.Models;

namespace TourManagerMVC.Web.Controllers
{
    public class ArtistController : Controller
    {
        private readonly IArtistService _artistService;
        public ArtistController(IArtistService artistService)
        {
            _artistService = artistService;
        }
        public IActionResult Index()
        {
            var artists = _artistService.GetAllArtists();
            return View(artists);
        }

    }
}
