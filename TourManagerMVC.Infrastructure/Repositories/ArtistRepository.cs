using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagerMVC.Domain.Interfaces;
using TourManagerMVC.Domain.Models;

namespace TourManagerMVC.Infrastructure.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly Context _context;
        public ArtistRepository(Context context)
        {
            _context = context;
        }

        public int AddArtist(Artist artist)
        {
            _context.Artists.Add(artist);
            _context.SaveChanges();
            return artist.Id;
        }

        public void DeleteArtist(int id)
        {
            var artist = _context.Artists.Find(id);
            if(artist != null)
            {
                _context.Artists.Remove(artist);
                _context.SaveChanges();
            }
        }

        public void UpdateArtist(Artist artist)
        {
            throw new NotImplementedException();
        }

        public Artist GetArtistById(int id)
        {
            var artist = _context.Artists.FirstOrDefault(a => a.Id == id);
            return artist;
        }

        public IQueryable<Artist> GetAllArtists()
        {
            var artists = _context.Artists;
            return artists;
        }
    }
}
