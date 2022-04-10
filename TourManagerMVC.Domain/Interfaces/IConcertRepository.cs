using TourManagerMVC.Domain.Models;

namespace TourManagerMVC.Domain.Interfaces
{
    public interface IConcertRepository
    {
        int AddConcert(Concert concert);
        void DeleteConcert(int id);
        void UpdateConcert(Concert concert);
        Concert GetConcertById(int id);
        IQueryable<Concert> GetAllConcerts();
    }
}
