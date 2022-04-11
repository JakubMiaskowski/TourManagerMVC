using Microsoft.EntityFrameworkCore;
using TourManagerMVC.Domain.Interfaces;
using TourManagerMVC.Domain.Models;
using TourManagerMVC.Infrastructure.Common;

namespace TourManagerMVC.Infrastructure.Repositories
{
    public class VenueRepository : BaseRepository<Venue>, IVenueRepository
    {
        public VenueRepository(Context context)
        {
            _context = context;
            _entitySource = _context.Venues;
        }
    }
}
