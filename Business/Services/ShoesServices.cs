using System.Collections.Generic;
using Business.Interfaces;
using DataAccses.Repository;
using Entities.Models;

namespace Business.Services
{
    public class ShoesServices : IShoes
    {
        public ShoesRepository shoesRepository { get; set; }
        private static int count { get; set; }
        public ShoesServices()
        {
            shoesRepository = new ShoesRepository();
        }
        public Shoes Creat(Shoes shoes)
        {
            shoes.RefId = count;
            Shoes IsExist = shoesRepository.Get(g => g.Type.ToLower() == shoes.Type.ToLower());
            if (IsExist != null)
                return null;
            shoesRepository.Create(shoes);
            count++;
            return shoes;
        }

        public Shoes Delete(int RefId)
        {
            throw new System.NotImplementedException();
        }

        public Shoes Get(int RefNum)
        {
            throw new System.NotImplementedException();
        }

        public Shoes Get(string Name)
        {
            throw new System.NotImplementedException();
        }

        public List<Shoes> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<Shoes> GetAll(int Size)
        {
            throw new System.NotImplementedException();
        }

        public Shoes Update(int RefId, Shoes shoes)
        {
            throw new System.NotImplementedException();
        }
    }
}
