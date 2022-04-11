using TourManagerMVC.Domain.Common;

namespace TourManagerMVC.Domain.Models
{
    public class Tour : BaseModel
    {
        public string Theme { get; set; }
        public Artist Headliner { get; set; }
        public IEnumerable<Concert> Concerts { get; set; }

        //Navigation Properties
        public int ArtistId { get; set; }
    }
}
