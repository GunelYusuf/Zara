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

        public Clothes Delete(int RefId)
        {
            Clothes clothes = clothesRepository.Get(g => g.RefId == RefId);
            if (clothes!=null)
            {
                clothesRepository.Delete(clothes);
                return clothes;
            }
            else
            {
                return null;
            }

            
        }

        public Clothes Get(int RefId)
        {
            throw new System.NotImplementedException();
        }

        public Clothes Get(string Type)
        {
            throw new System.NotImplementedException();
        }

        public List<Clothes> GetAll()
        {
            return clothesRepository.GetAll();
        }

        public List<Clothes> GetAll(int Size)
        {
            throw new System.NotImplementedException();
        }

        public Clothes Update(int RefId, Clothes clothes)
        {
            throw new System.NotImplementedException();
        }
    }
}
