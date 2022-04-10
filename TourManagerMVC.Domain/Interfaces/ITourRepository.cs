using TourManagerMVC.Domain.Models;

namespace TourManagerMVC.Domain.Interfaces
{
    public interface ITourRepository
    {
        int AddTour(Tour tour);
        void DeleteTour(int id);
        void UpdateTour(Tour tour);
        Tour GetTourById(int id);
        IQueryable<Tour> GetAllTours();
    }
}
