﻿using AutoMapper;
using TourManagerMVC.Application.Mapping;

namespace TourManagerMVC.Application.ViewModels.Venue
{
    public class ListOfVenuesVm : IMapFrom<TourManagerMVC.Domain.Models.Venue>
    {
        public IEnumerable<VenueForListVm> Venues { get; set; }
        public int Count { get; set; }
        public int? CurrentPage { get; set; }
        public int PageSize { get; set; }
        public string SearchString { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TourManagerMVC.Domain.Models.Venue, ListOfVenuesVm>()
                .ForMember(p => p.Venues, opt => opt.Ignore());
        }
    }
}
