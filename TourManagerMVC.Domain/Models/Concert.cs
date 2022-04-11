using TourManagerMVC.Domain.Common;

namespace TourManagerMVC.Domain.Models
{
    public class Concert : BaseModel
    {
        public string Title { get; set; }
        public IEnumerable<Artist> Artists { get; set; }
        public Venue Venue { get; set; }
        public DateTime Date { get; set; }
        public double TicketCost { get; set; }

        //Navigation Properties
        public int TourId { get; set; }
        public Tour Tour { get; set; }
        public int CalendarId { get; set; }
        public EventsCalendar Calendar { get; set; }
        public IList<ArtistConcert> ArtistConcerts { get; set; }
        public int VenueId { get; set; }
    }
}
