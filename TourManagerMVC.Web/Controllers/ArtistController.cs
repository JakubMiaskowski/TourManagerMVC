using Microsoft.AspNetCore.Mvc;
using TourManagerMVC.Application.ViewModels.Artist;

namespace TourManagerMVC.Web.Controllers
{
    public class ArtistController : Controller
    {

        public IActionResult All()
        {
            IList<ArtistDetailsVM> artists = new List<ArtistDetailsVM>();
            artists.Add(new ArtistDetailsVM { Id = 1, Name = "AC/DC" });
            artists.Add(new ArtistDetailsVM { Id = 2, Name = "Tool" });
            artists.Add(new ArtistDetailsVM { Id = 3, Name = "Black Sabbath" });
            artists.Add(new ArtistDetailsVM { Id = 4, Name = "1000 Mods" });
            return View(artists);
        }

        public IActionResult ById(int id)
        {
            IList<ArtistDetailsVM> artists = new List<ArtistDetailsVM>();
            artists.Add(new ArtistDetailsVM { Id = 1, Name = "AC/DC" });
            artists.Add(new ArtistDetailsVM { Id = 2, Name = "Tool" });
            artists.Add(new ArtistDetailsVM { Id = 3, Name = "Black Sabbath" });
            artists.Add(new ArtistDetailsVM { Id = 4, Name = "1000 Mods" });

            var artist = artists.FirstOrDefault(p => p.Id == id);
            return View(artist);

        }
    }
}
