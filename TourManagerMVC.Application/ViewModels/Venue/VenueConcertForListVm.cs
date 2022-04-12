using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagerMVC.Application.Mapping;

namespace TourManagerMVC.Application.ViewModels.Venue
{
    public class VenueConcertForListVm : IMapFrom<TourManagerMVC.Domain.Models.Concert>
    {
        public string Title { get; set; }
        public string LineUp { get; set; }
        public string Date { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TourManagerMVC.Domain.Models.Concert, VenueConcertForListVm>()
                .ForMember(p => p.LineUp, opt => opt.MapFrom(d => string.Join(" // ", d.Artists)))
                .ForMember(p => p.Date, opt => opt.MapFrom(d => $"{d.Date.Day} - {d.Date.Month} - {d.Date.Year}"));
        }
    }
}
