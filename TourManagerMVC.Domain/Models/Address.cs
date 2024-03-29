﻿using TourManagerMVC.Domain.Common;

namespace TourManagerMVC.Domain.Models
{
    public class Address : BaseModel
    { 
        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public string Country { get; set; }

        //Navigation Properties
        public int VenueId { get; set; }
        public virtual Venue Venue { get; set; }
    }
}
