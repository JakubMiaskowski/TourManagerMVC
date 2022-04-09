using TourManagerMVC.Domain.Common;

namespace TourManagerMVC.Domain.Models
{
    public class Artist : BaseModel
    {
        public string Name { get; set; }


        public int TourId { get; set; }
        public IList<Tour> Tours { get; set; }
        public IList<ArtistConcert> ArtistConcerts { get; set; }


    }
}
