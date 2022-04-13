using TourManagerMVC.Domain.Common;

namespace TourManagerMVC.Domain.Models
{
    public class Concert : BaseModel
    {
        public string Title { get; set; }
        public virtual IEnumerable<Artist> Artists { get; set; }
        public virtual Venue Venue { get; set; }
        public DateTime Date { get; set; }
        public double TicketCost { get; set; }

        //Navigation Properties
        public int TourId { get; set; }
        public virtual Tour Tour { get; set; }
        public int CalendarId { get; set; }
        public virtual EventsCalendar Calendar { get; set; }
        public virtual IList<ArtistConcert> ArtistConcerts { get; set; }
        public int VenueId { get; set; }
    }
}
