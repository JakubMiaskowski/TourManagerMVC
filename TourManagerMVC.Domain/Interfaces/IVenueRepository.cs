using TourManagerMVC.Domain.Models;

namespace TourManagerMVC.Domain.Interfaces
{
    public interface IVenueRepository
    {
        int AddVenue(Venue venue);
        void DeleteVenue(int id);
        void UpdateVenue(Venue venue);
        Venue GetVenueById(int id);
        IQueryable<Venue> GetAllVenues();
    }
}
