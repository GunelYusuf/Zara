using System;
using System.Collections.Generic;
using DataAccses.Interface;
using Entities.Models;

namespace DataAccses.Repository
{
    public class CategoryRepository /*: IRepository <Category>*/
    {
        public bool Create(Category entity)
        {
            try
            {
                DbContext.Category.Add(entity);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Category entity)
        {
            try
            {
               DbContext.Category.Remove(entity);
               return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Category Get(Predicate<Category> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Category[0]
               : DbContext.Category.Find(filter);

            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Category> GetAll(Predicate<Category> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Category
                    : DbContext.Category.FindAll(filter);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Update(Category entity,string newName)
        {
            try
            {
                entity.categoryName = newName;
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
