using TourManagerMVC.Domain.Models;

namespace TourManagerMVC.Domain.Interfaces
{
    public interface IArtistRepository
    {
        int AddArtist(Artist artist);
        void DeleteArtist(int id);
        void UpdateArtist(Artist artist);
        Artist GetArtistById(int id);
        IQueryable<Artist> GetAllArtists();
    }
}
