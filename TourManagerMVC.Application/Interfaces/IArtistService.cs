using TourManagerMVC.Domain.Models;

namespace TourManagerMVC.Application.Interfaces
{
    public interface IArtistService
    {
        IEnumerable<Artist> GetAllArtists();
    }
}
