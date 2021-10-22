using System;
using System.Collections.Generic;
using Entities.Interface;

namespace DataAccses.Interface
{
    public interface IRepository<T> where T: IEntity
    {
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        List<T> GetAll(Predicate<T> filter=null);
        T Get(Predicate<T> filter=null);
      
    }
}
