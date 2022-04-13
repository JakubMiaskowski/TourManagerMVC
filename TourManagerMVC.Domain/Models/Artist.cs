using TourManagerMVC.Domain.Common;

namespace TourManagerMVC.Domain.Models
{
    public class Artist : BaseModel
    {
        public string Name { get; set; }

        //Navigation Properties
        public virtual IList<Tour> Tours { get; set; }
        public virtual IList<ArtistConcert> ArtistConcerts { get; set; }
    }
}
