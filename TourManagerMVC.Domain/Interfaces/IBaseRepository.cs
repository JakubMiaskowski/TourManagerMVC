using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagerMVC.Domain.Common;

namespace TourManagerMVC.Domain.Interfaces
{
    public interface IBaseRepository<T> where T:BaseModel
    {
        int Add(T element);
        void Delete(T id);
        void Update(T element);
        IQueryable<T> GetAllElements();
        T GetElementById(int id);
    }
}
