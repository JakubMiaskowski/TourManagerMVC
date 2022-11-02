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
        public IQueryable<Venue> GetVeuesByCity(string city)
        {
            var venuesByCity = _entitySource.Where(p => p.Address.City == city);
            return venuesByCity;
        }

        public override IQueryable<Venue> GetAllElements()
        {
            var venues = new List<Venue>()
            {
                new Venue { Id = 1, Name = "Baszta", Address = new Address{City = "Malbork"}},
                new Venue { Id = 2, Name = "Rewolwer", Address = new Address{City = "Olsztyn"}},
                new Venue { Id = 3, Name = "Carpenter", Address = new Address{City = "Olsztyn"} },
                new Venue { Id = 4, Name = "NRD", Address = new Address{City = "Olsztyn"} },
                new Venue { Id = 5, Name = "Alternatywa", Address = new Address{City = "Malbork"} },
                new Venue { Id = 6, Name = "Wiraż", Address = new Address{City = "Olsztyn"} },
                new Venue { Id = 7, Name = "Akcent", Address = new Address{City = "Bydgoszcz"} },
                new Venue { Id = 8, Name = "Avia", Address = new Address{City = "Bydgoszcz"} },
                new Venue { Id = 9, Name = "Andergrant", Address = new Address{City = "Olsztyn"} },
                new Venue { Id = 10, Name = "Estrada", Address = new Address{City = "Bydgoszcz"} },
                new Venue { Id = 11, Name = "Potok", Address = new Address{City = "Warszawa"} }
            };
            return venues.AsQueryable();
        }
    }
}
