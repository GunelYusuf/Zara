using System;
using System.Collections.Generic;
using DataAccses.Interface;
using Entities.Models;

namespace DataAccses.Repository
{
    public class ClothesRepository : IRepository<Clothes> 
    {
        public bool Create(Clothes entity)
        {
            try
            {
                DbContext.Clothes.Add(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Clothes entity)
        {
            try
            {
                DbContext.Clothes.Remove(entity);
                return true;
            }
            catch (Exception )
            {
                throw;
            }
        }

        public Clothes Get(Predicate<Clothes> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Clothes[0]
               : DbContext.Clothes.Find(filter);
                
            }
            catch (Exception )
            {
                throw;
            }
        }

        public List<Clothes> GetAll(Predicate<Clothes> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Clothes
                    : DbContext.Clothes.FindAll(filter);
            }
            catch (Exception )
            {
                throw;
            }
        }

        public bool Update(Clothes entity)
        {
            try
            {
                Clothes dbClothes = Get(c => c.RefId == entity.RefId);
                dbClothes = entity;
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
