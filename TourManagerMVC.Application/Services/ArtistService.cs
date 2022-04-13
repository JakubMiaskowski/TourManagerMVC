using TourManagerMVC.Application.Interfaces;
using TourManagerMVC.Domain.Interfaces;
using TourManagerMVC.Domain.Models;

namespace TourManagerMVC.Application.Services
{
    public class ArtistService : IArtistService
    {
        private readonly IArtistRepository _artistRepository;
        public ArtistService(IArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }
        public IEnumerable<Artist> GetAllArtists()
        {
            var artists = _artistRepository.GetAllElements();
            return artists;
        }
    }
}
