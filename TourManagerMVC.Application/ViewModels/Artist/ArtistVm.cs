using AutoMapper;
using TourManagerMVC.Application.Mapping;

namespace TourManagerMVC.Application.ViewModels.Artist
{
    public class ArtistVm : IMapFrom<TourManagerMVC.Domain.Models.Artist>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TourManagerMVC.Domain.Models.Artist, ArtistVm>();
        }
    }
}
