using System;
using System.Collections.Generic;
using DataAccses.Interface;
using Entities.Models;

namespace DataAccses.Repository
{
    public class CategoryRepository /*: IRepository <Category>*/
    {
        public CategoryRepository()
        {
        }

        public bool Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Predicate<Category> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Predicate<Category> filter = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
