using System;
using System.Collections.Generic;
using DataAccses.Interface;
using Entities.Models;

namespace DataAccses.Repository
{
    public class DressRepository: IRepository <Dress>
    {
        public bool Create(Dress entity)
        {
            try
            {
                DbContext.Dresses.Add(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Dress entity)
        {
            try
            {
                DbContext.Dresses.Remove(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Dress Get(Predicate<Dress> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Dresses[0]
                : DbContext.Dresses.Find(filter);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public List<Dress> GetAll(Predicate<Dress> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Dresses
                    : DbContext.Dresses.FindAll(filter);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(Dress entity)
        {
            try
            {
                Dress midi = DbContext.Dresses.Find(m => m.RefId == entity.RefId);
                midi = entity;
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
