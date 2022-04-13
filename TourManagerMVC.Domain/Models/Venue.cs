using TourManagerMVC.Domain.Common;

namespace TourManagerMVC.Domain.Models
{
    public class Venue : BaseModel
    {
        public string Name { get; set; }

        public string Owner { get; set; }

        public virtual EventsCalendar Calendar { get; set; }

        public virtual Address Address { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int Capacity { get; set; }


        //Navigation Properties
        public int AddressId { get; set; }
        public virtual IList<Concert> Concerts { get; set; }

    }
}
