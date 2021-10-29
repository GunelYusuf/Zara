using System;
using System.Collections.Generic;
using Business.Interfaces;
using DataAccses.Repository;
using Entities.Models;

namespace Business.Services
{
    public class DressServices : IDress
    {
        private DressRepository dressRepository  { get; set; }
        private ClothesServices clothesServices { get; set; }
        private static int count;

        public DressServices()
        {
            dressRepository = new DressRepository();
            clothesServices = new ClothesServices();
        }


        public Dress Create(Dress dress, string clothesType)
        {
            Clothes dbClothes = clothesServices.Get(clothesType);
            if (dbClothes!=null)
            {
                dress.Clothes =dbClothes;
                dress.RefId = count;
                dressRepository.Create(dress);
                count++;
                return dress;
            }
            else
            {
                return null;
            }
        }

        public Dress Delete(int RefId)
        {
            throw new NotImplementedException();
        }

        public Dress Get(int RefId)
        {
            throw new NotImplementedException();
        }

        public List<Clothes> Get(string name)
        {
            throw new NotImplementedException();
        }

        public List<Clothes> GetAll(string clothesType)
        {
            Clothes dbClothes = clothesServices.Get(clothesType);
            if (dbClothes!=null)
            {
                return dressRepository.GetAll(d => d.Clothes.Type == dbClothes.Type);
            }
            else
            {
                return null;
            }
        }

        public List<Clothes> GetAll()
        {
            throw new NotImplementedException();
        }

        public Dress Update(Dress dress, string clothesType)
        {
            throw new NotImplementedException();
        }
    }
}
