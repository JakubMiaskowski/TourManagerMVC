using TourManagerMVC.Domain.Interfaces;
using TourManagerMVC.Domain.Models;
using TourManagerMVC.Infrastructure.Common;

namespace TourManagerMVC.Infrastructure.Repositories
{
    public class ArtistRepository : BaseRepository<Artist>, IArtistRepository
    {
        public ArtistRepository(Context context)
        {
            _context = context;
            _entitySource = _context.Artists;
        }
    }
}
