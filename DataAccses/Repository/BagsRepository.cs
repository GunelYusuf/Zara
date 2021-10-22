using System;
using System.Collections.Generic;
using DataAccses.Interface;
using Entities.Models;

namespace DataAccses.Repository
{
    public class BagsRepository : IRepository<Bags>
    {
        public bool Create(Bags entity)
        {
            try
            {
               DbContext.Bags.Add(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Bags entity)
        {
            try
            {
                DbContext.Bags.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Bags Get(Predicate<Bags> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Bags[0]
               : DbContext.Bags.Find(filter);

            }
            catch (Exception)
            {
                throw;
            }
           
        }

        public List<Bags> GetAll(Predicate<Bags> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Bags
                    : DbContext.Bags.FindAll(filter);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(Bags entity)
        {
            try
            {
                Bags dbBags = Get(c => c.RefId == entity.RefId);
                dbBags = entity;
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
