using System.Collections.Generic;
using Entities.Models;

namespace Business.Interfaces
{
    public interface IClothes
    {
        Clothes Create(Clothes clothes);
        Clothes Update(int RefId, Clothes clothes);
        Clothes Delete(int RefId);
        Clothes Get(int RefId);
        Clothes Get(string Type);
       
        List<Clothes> GetAll();
        List<Clothes> GetAll(int Quantity);

    }
}
