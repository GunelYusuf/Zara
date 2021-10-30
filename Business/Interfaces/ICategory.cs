using System;
using System.Collections.Generic;
using Entities.Models;

namespace Business.Interfaces
{
    public interface ICategory
    {
        Category Create(Category category);
        Category Update(string category,string name);
        Category Delete(string category);
        Category Get(string category);

        List<Category> GetAll();
        List<Category> GetAll(int Quantity);
    }
}
