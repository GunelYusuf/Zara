using System;
using System.Collections.Generic;
using DataAccses.Interface;
using Entities.Models;

namespace DataAccses.Repository
{
    public class ShoesRepository : IRepository<Shoes>
    {
        public bool Create(Shoes entity)
        {
            try
            {
                DbContext.Shoes.Add(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Shoes entity)
        {
            try
            {
                DbContext.Shoes.Remove(entity);
                return true;
            }
            catch (Exception )
            {
                throw;
            }
        }

        public Shoes Get(Predicate<Shoes> filter = null)
        {
            try
            {
              return  filter == null ? DbContext.Shoes[0]
                      : DbContext.Shoes.Find(filter);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Shoes> GetAll(Predicate<Shoes> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Shoes
                       : DbContext.Shoes.FindAll(filter);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public bool Update(Shoes entity)
        {
            try
            {
                Shoes dbShoes = Get(c => c.RefId == entity.RefId);
                dbShoes = entity;
                return true;
            }
            catch (Exception)
            {
                throw;
            } 
        }
    }
}
