using AutoMapper;
using TourManagerMVC.Application.Mapping;

namespace TourManagerMVC.Application.ViewModels.Venue
{
    public class VenueForListVm : IMapFrom<TourManagerMVC.Domain.Models.Venue>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TourManagerMVC.Domain.Models.Venue, VenueForListVm>()
                .ForMember(p => p.City, opt => opt.MapFrom(d => d.Address.City));
        }

    }
}
