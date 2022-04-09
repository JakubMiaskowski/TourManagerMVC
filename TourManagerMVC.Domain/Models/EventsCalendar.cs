using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourManagerMVC.Domain.Models
{
    public class EventsCalendar
    {
        public int Id { get; set; }
        public IEnumerable<Concert> Concerts { get; set; }

        public int VenueId { get; set; }
        public Venue Venue { get; set; }
    }
}
