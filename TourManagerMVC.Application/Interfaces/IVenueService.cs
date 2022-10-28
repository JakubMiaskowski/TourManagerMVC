using TourManagerMVC.Application.ViewModels.Venue;

namespace TourManagerMVC.Application.Interfaces
{
    public interface IVenueService
    {
        ListOfVenuesVm GetAllVenues(int pageSize, int pageNo, string searchString);
        VenueDetailsVm GetVenueDetails(int id);
        int AddVenue(NewVenueVm venue);
    }
}
