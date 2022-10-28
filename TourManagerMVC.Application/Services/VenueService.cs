using AutoMapper;
using AutoMapper.QueryableExtensions;
using TourManagerMVC.Application.Interfaces;
using TourManagerMVC.Application.ViewModels.Venue;
using TourManagerMVC.Domain.Interfaces;
using TourManagerMVC.Domain.Models;

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

        public int AddVenue(NewVenueVm venue)
        {
            var newVenue = new Venue
            {
                Name = venue.Name,
                Owner = venue.Owner,
                Calendar = new EventsCalendar(),
                Address = new Address
                {
                    StreetAddress = venue.StreetAddress,
                    City = venue.City,
                    ZipCode = venue.ZipCode,
                    Country = venue.Country
                },
                Email = venue.Email,
                Phone = venue.Phone,
                Capacity = venue.Capacity
            };

            var id = _venueRepository.Add(newVenue);
            return id;
        }

        public ListOfVenuesVm GetAllVenues(int pageSize, int? pageNo, string searchString)
        {
            var venues = _venueRepository
                            .GetAllElements()
                            .Where(p => p.Address.City.StartsWith(searchString))
                            .ProjectTo<VenueForListVm>(_mapper.ConfigurationProvider)
                            .ToList();

            var customersToShow = venues.Skip(pageSize * ((int)pageNo - 1)).Take(pageSize).ToList();


            var listOfVenues = new ListOfVenuesVm
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                SearchString = searchString,
                Venues = customersToShow,
                Count = venues.Count
            };

            return listOfVenues;
        }

        public VenueDetailsVm GetVenueDetails(int id)
        {
            var venueById = _venueRepository.GetElementById(id) ??
                throw new Exception($"Venue with id {id} doesn't exist");

            var venueDetails = _mapper.Map<VenueDetailsVm>(venueById);
            return venueDetails;
        }
    }
}
