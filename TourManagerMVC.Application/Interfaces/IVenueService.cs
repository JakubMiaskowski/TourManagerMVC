using TourManagerMVC.Application.ViewModels.Venue;

namespace TourManagerMVC.Application.Interfaces
{
    public interface IVenueService
    {
        ListOfVenuesVm GetAllVenues();
        ListOfVenuesVm GetVenuesByCity(string city);
        VenueDetailsVm GetVenueDetails(int id);
        int AddVenue(NewVenueVm venue);
    }
}
