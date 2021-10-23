using System;
using System.Collections.Generic;
using Business.Interfaces;
using DataAccses.Repository;
using Entities.Models;
 

namespace Business.Services
{
    public class ClothesServices : IClothes
    {
        public ClothesRepository clothesRepository { get; set; }
        private static int count { get; set; }
        public ClothesServices()
        {
            clothesRepository = new ClothesRepository();
        }

        public Clothes Create(Clothes clothes)
        {
            try
            {
                clothes.RefId = count;
                Clothes IsExist = clothesRepository.Get(g => g.Type.ToLower() == clothes.Type.ToLower());
                if (IsExist != null) return null;
                clothesRepository.Create(clothes);
                count++;
                return clothes;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Clothes> GetAll()
        {
            return clothesRepository.GetAll();
        }
       

        public List<Clothes> GetAll(int Quantity)
        {
            List<Clothes> clothes = clothesRepository.GetAll(g => g.Quantity == Quantity);
            return clothes;
            
        }

        public Clothes Update(int RefId, Clothes clothes)
        {
            try
            {
                Clothes dbClothes = clothesRepository.Get(s => s.RefId == clothes.RefId);
                dbClothes.Type = clothes.Type;
                dbClothes.RefId = clothes.RefId;
                return clothes;
            }
            catch (Exception)
            {
                return null;
            }
            
        }

        public Clothes Delete(int RefId)
        {
            Clothes dbClothes = clothesRepository.Get(g => g.RefId == RefId);
            if (dbClothes != null)
            {
                clothesRepository.Delete(dbClothes);
                return dbClothes;
            }
            else
            {
                return null;
            }
        }

        public Clothes Get(int RefId)
        {
            Clothes dbClothes = clothesRepository.Get(g => g.RefId == RefId);
            if (dbClothes != null)
            {
               
                return dbClothes;
            }
            else
            {
                return null;
            }
        }

        public Clothes Get(string Type)
        {
            Clothes dbClothes = clothesRepository.Get(g => g.Type == Type);
            if (dbClothes != null)
            {
                return dbClothes;
            }
            else
            {
                return null;
            }
        }
    }
}
