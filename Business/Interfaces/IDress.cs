using System;
using System.Collections.Generic;
using Entities.Models;

namespace Business.Interfaces
{
    public interface IDress
    {
        Dress Create(Dress dress, string clothesType);
        Dress Delete(int RefId);
        Dress Update(Dress dress, string clothesType);
        Dress Get(int RefId);
        
        List<Clothes> Get(string type);
        List<Clothes> GetAll(string clothesType);
        List<Clothes> GetAll();
    }
}
