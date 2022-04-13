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
        public virtual IEnumerable<Concert> Concerts { get; set; }

        //Navigation Properties
        public int VenueId { get; set; }
        public virtual Venue Venue { get; set; }
    }
}
