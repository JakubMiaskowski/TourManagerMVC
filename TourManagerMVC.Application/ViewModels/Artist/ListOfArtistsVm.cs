using AutoMapper;
using TourManagerMVC.Application.Mapping;

namespace TourManagerMVC.Application.ViewModels.Artist
{
    public class ListOfArtistsVm : IMapFrom<TourManagerMVC.Domain.Models.Artist>
    {
        public IEnumerable<ArtistVm> Artists { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TourManagerMVC.Domain.Models.Artist, ListOfArtistsVm>()
                .ForMember(p => p.Artists, opt => opt.Ignore());
        }
    }
}
