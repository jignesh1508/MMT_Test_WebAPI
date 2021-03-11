using System;
using System.Collections.Generic;

namespace ApplicationCore.Interface
{
    public interface IRepository<T> where T:class
    {
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        IEnumerable<T> ListAll(string procedure);
        IEnumerable<T> ListAllById(int id,string procedure);
        
    }
}
