using System.Collections.Generic;

namespace WebApplication4.Models
{
    public interface IRepository<T> where T : class
    {
        bool Add(T item);
        bool Delete(T item);
        bool Delete(int id);
        bool Update(T item);
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}
