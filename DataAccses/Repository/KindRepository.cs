using System;
using System.Collections.Generic;
using DataAccses.Interface;
using Entities.Models;

namespace DataAccses.Repository
{
    public class KindRepository /*:IRepository<Kind>*/
    {
        public KindRepository()
        {
        }

        public bool Create(Kind entity)
        {
            try
            {
                DbContext.Kind.Add(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Kind entity)
        {
            try
            {
                DbContext.Kind.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Kind Get(Predicate<Kind> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Kind[0]
               : DbContext.Kind.Find(filter);

            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Kind> GetAll(Predicate<Kind> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Kind
                    : DbContext.Kind.FindAll(filter);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(Kind entity)
        {
            throw new NotImplementedException();
        }
    }
}
