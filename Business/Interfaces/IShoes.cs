using System.Collections.Generic;
using Entities.Models;

namespace Business.Interfaces
{
    public interface IShoes
    {
        Shoes Creat(Shoes shoes);
        Shoes Delete(int RefId);
        Shoes Update(int RefId, Shoes shoes);
        Shoes Get(int RefId);
        Shoes Get(string Type);
        List<Shoes> GetAll();
        List<Shoes> GetAll(int Quantity);
    }
}
