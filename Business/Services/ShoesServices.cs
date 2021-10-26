using System;
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
            try
            {
                shoes.RefId = count;
                Shoes IsExist = shoesRepository.Get(g => g.Type.ToLower() == shoes.Type.ToLower());
                Shoes IsExist1 = shoesRepository.Get(g => g.Size == shoes.Size);
                if (IsExist != null && IsExist1 != null) return null;
                shoesRepository.Create(shoes);
                count++;
                return shoes;

            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public Shoes Delete(int RefId)
        {
            Shoes dbShoes = shoesRepository.Get(g => g.RefId == RefId);
            if (dbShoes != null)
            {
                shoesRepository.Delete(dbShoes);
                return dbShoes;
            }
            else
            {
                return null;
            }
        }

        public Shoes Get(int RefId)
        {
           Shoes dbShoes = shoesRepository.Get(g => g.RefId == RefId);
            if (dbShoes != null)
            {
                return dbShoes;
            }
            else
            {
                return null;
            }
        }

        public Shoes Get(string Type)
        {
           Shoes dbShoes = shoesRepository.Get(g => g.Type == Type);
            if (dbShoes != null)
            {
                return dbShoes;
            }
            else
            {
                return null;
            }
        }

        public List<Shoes> GetAll()
        {
            return shoesRepository.GetAll();
        }

        public List<Shoes> GetAll(int Quantity)
        {
            List <Shoes> makasin = shoesRepository.GetAll(g => g.Quantity == Quantity);
            return makasin;
        }

        public Shoes Update(int RefId, Shoes shoes)
        {
            try
            {
                Shoes dbmakasin = shoesRepository.Get(p => p.RefId == shoes.RefId);
                dbmakasin.Type = shoes.Type;
                dbmakasin.RefId = shoes.RefId;
                return shoes;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
