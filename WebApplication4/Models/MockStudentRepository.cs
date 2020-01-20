using System;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication4.Models
{
    public class MockStudentRepository<T> : IStudentRepository<T> where T : class, IStudent
    {
        private List<T> _students { get; set; } = new List<T>();
        public MockStudentRepository()
        {
            for(int i = 0; i < 5; i++)
            {
                T newInstance = Activator.CreateInstance(typeof(T)) as T;
                newInstance.Id = i + 1;
                newInstance.Name = "Student " + (i + 1);
                newInstance.Age = i + 1;
                _students.Add(newInstance);
            }
        }

        public T Get(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _students;
        }

        public bool Add(T item)
        {
            try
            {
                _students.Add(item);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(T item)
        {
            try
            {
                _students.Remove(item);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(int id)
        {
            try
            {
                T item = _students.FirstOrDefault(s => s.Id == id);
                _students.Remove(item);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(T item)
        {
            var isDeleted = Delete(item.Id);
            if(isDeleted)
                return Add(item);

            return false;
        }
    }
}
