using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagerMVC.Application.Mapping;

namespace TourManagerMVC.Application.ViewModels.Venue
{
    public class VenueConcertListVm : IMapFrom<TourManagerMVC.Domain.Models.Concert>
    {
        public IEnumerable<VenueConcertForListVm> Concerts { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TourManagerMVC.Domain.Models.Concert, VenueConcertListVm>()
                .ForMember(p => p.Concerts, opt => opt.Ignore());
        }
    }
}
