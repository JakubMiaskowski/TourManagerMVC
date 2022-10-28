using TourManagerMVC.Domain.Interfaces;
using TourManagerMVC.Domain.Models;
using TourManagerMVC.Infrastructure.Common;

namespace TourManagerMVC.Infrastructure.Repositories
{
    public class ConcertRepository : BaseRepository<Concert>, IConcertRepository
    {
        public ConcertRepository(Context context)
        {
            _context = context;
            _entitySource = _context.Concerts;
        }
    }
}
