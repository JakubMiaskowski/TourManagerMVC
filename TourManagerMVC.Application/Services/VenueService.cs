using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagerMVC.Application.Interfaces;
using TourManagerMVC.Domain.Interfaces;

namespace TourManagerMVC.Application.Services
{
    public class VenueService : IVenueService
    {
        private readonly IVenueRepository _venueRepository;

        private readonly IMapper _mapper;
        public VenueService(
            IVenueRepository venueRepository,
            IMapper mapper)
        {
            _venueRepository = venueRepository;
            _mapper = mapper;
        }
    }
}
