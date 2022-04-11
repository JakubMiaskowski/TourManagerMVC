using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagerMVC.Domain.Models;

namespace TourManagerMVC.Application.Interfaces
{
    public interface IArtistService
    {
        IEnumerable<Artist> GetAllArtists();
    }
}
