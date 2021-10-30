using System;
using System.Collections.Generic;
using Entities.Models;

namespace Business.Interfaces
{
    public interface ICategory
    {
        Category Create(Category type);
        Category Update(int RefId, Category type);
        Category Delete(int RefId);
        Category Get(string Type);

        List<Category> GetAll();
        List<Category> GetAll(int Quantity);
    }
}
