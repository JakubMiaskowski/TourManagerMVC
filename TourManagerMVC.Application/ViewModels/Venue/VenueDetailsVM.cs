using TourManagerMVC.Application.Mapping;

namespace TourManagerMVC.Application.ViewModels.Venue
{
    public class VenueDetailsVM : IMapFrom<TourManagerMVC.Domain.Models.Venue>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(MappingProfile profile)
        {
            profile.CreateMap<TourManagerMVC.Domain.Models.Venue, VenueDetailsVM>()
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id))
                .ForMember(d => d.Id, opt => opt.MapFrom(s => s.Id));
        }
    }
}
