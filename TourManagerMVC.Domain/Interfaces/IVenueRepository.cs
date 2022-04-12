using TourManagerMVC.Domain.Models;

namespace TourManagerMVC.Domain.Interfaces
{
    public interface IVenueRepository : IBaseRepository<Venue>
    {
        IQueryable<Venue> GetVeuesByCity(string city);
    }
}
