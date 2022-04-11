using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagerMVC.Domain.Interfaces;
using TourManagerMVC.Domain.Models;
using TourManagerMVC.Infrastructure.Common;

namespace TourManagerMVC.Infrastructure.Repositories
{
    public class TourRepository : BaseRepository<Tour>, ITourRepository
    {
        public TourRepository(Context context)
        {
            _context = context;
            _entitySource = _context.Tours;
        }
    }
}
