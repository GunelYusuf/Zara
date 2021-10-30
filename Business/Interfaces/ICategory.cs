using System;
using System.Collections.Generic;
using Entities.Models;

namespace Business.Interfaces
{
    public interface ICategory
    {
        Category Create(Category category);
        Category Update(int RefId, Category category);
        Category Delete(int RefId);
        Category Get(string category);

        List<Category> GetAll();
        List<Category> GetAll(int Quantity);
    }
}
