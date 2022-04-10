using TourManagerMVC.Domain.Common;

namespace TourManagerMVC.Domain.Models
{
    public class Venue : BaseModel
    {
        public string Name { get; set; }

        public VenueType Type { get; set; }

        public string Owner { get; set; }

        public EventsCalendar Calendar { get; set; }

        public Address Address { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int Capacity { get; set; }



        public IList<Concert> Concerts { get; set; }

    }
}
