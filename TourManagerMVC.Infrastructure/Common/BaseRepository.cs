using Microsoft.EntityFrameworkCore;
using TourManagerMVC.Domain.Common;
using TourManagerMVC.Domain.Interfaces;

namespace TourManagerMVC.Infrastructure.Common
{
    public abstract class BaseRepository<T> : IBaseRepository<T>  
        where T : BaseModel
    {   
        protected Context _context;
        protected DbSet<T> _entitySource;

        public int Add(T element)
        {
            _entitySource.Add(element);
            _context.SaveChanges();
            return element.Id;
        }

        public void Delete(T id)
        {
            var element = _entitySource.Find(id);
            if (element == null) return;
            _entitySource.Remove(element);
            _context.SaveChanges();
        }

        public void Update(T element)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAllElements()
        {
            var elements = _entitySource;
            return elements;
        }

        public T GetElementById(int id)
        {
            var element = _entitySource.FirstOrDefault(p => p.Id == id);
            return element;
        }

        
    }
}
