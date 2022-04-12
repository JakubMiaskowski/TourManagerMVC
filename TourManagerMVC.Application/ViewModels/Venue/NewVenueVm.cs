using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagerMVC.Application.Mapping;

namespace TourManagerMVC.Application.ViewModels.Venue
{
    public class NewVenueVm : IMapFrom<TourManagerMVC.Domain.Models.Venue>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Capacity { get; set; }

        public void Mapping(Profile profile)
        {

        }
    }
}
