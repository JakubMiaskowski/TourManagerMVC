using TourManagerMVC.Application.Mapping;

namespace TourManagerMVC.Application.ViewModels.Venue
{
    public class VenueDetailsVm : IMapFrom<TourManagerMVC.Domain.Models.Venue>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string AddressInformation { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Capacity { get; set; }


        public void Mapping(MappingProfile profile)
        {
            profile.CreateMap<TourManagerMVC.Domain.Models.Venue, VenueDetailsVm>()
                .ForMember(p => p.AddressInformation, opt => opt.MapFrom(d =>
                    $"{d.Address.StreetAddress}\r\n {d.Address.ZipCode} {d.Address.City}"));
        }
    }
}
