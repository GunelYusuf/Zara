using System;
using System.Collections.Generic;
using Business.Interfaces;
using DataAccses.Repository;
using Entities.Models;
using Utilies;

namespace Business.Services
{
    public class ClothesServices /*: IClothes*/
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
                Clothes IsExist =clothesRepository.Get(g => g.Category == clothes.Category && g.Size == clothes.Size && g.Kind==clothes.Kind);
                if (IsExist != null) return null;
                clothesRepository.Create(clothes);
                count++;
                return clothes;
            }
            catch (ExceptionsMessage)
            {
                throw new ExceptionsMessage(ExceptionsMessage.ClothesNotAddMessage);
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

        //public Clothes Update(int RefId, Clothes clothes)
        //{
        //    try
        //    {
        //        Clothes dbClothes = clothesRepository.Get(s => s.RefId == clothes.RefId);
        //        if (dbClothes != null)
        //        {
        //            dbClothes.Type = clothes.Type;
        //            dbClothes.RefId = clothes.RefId;
        //            return clothes;
        //        }
        //        else
        //        {
        //            return null;
        //        }

        //    }
        //    catch (ExceptionsMessage)
        //    {
        //        Console.WriteLine(ExceptionsMessage.ClothesNotUpdateMessage);
        //        return default;
        //    }
        //}

        public Clothes Delete(int RefId)
        {
            try
            {
                Clothes dbClothes = clothesRepository.Get(g => g.RefId == RefId);
                if (dbClothes != null)
                {
                    clothesRepository.Delete(dbClothes);
                    return dbClothes;
                }
                else
                {
                    throw new ExceptionsMessage();
                }
            }
            catch (ExceptionsMessage)
            {
                Console.WriteLine(ExceptionsMessage.ClothesNotDeleteMessage);
                return null;
                
            }
            
        }

        public Clothes Get(int RefId)
        {
            try
            {
                Clothes dbClothes = clothesRepository.Get(g => g.RefId == RefId);
                if (dbClothes != null)
                {
                    return dbClothes;
                }
                else
                {
                    throw new ExceptionsMessage();
                }
            }
            catch (ExceptionsMessage)
            {
                Console.WriteLine(ExceptionsMessage.ClothesNotFoundMessage);
                return null;
            }
            
        }

        public Clothes Get(string category)
        {
            try
            {
                Clothes dbClothes = clothesRepository.Get(g => g.Category.ToLower() == category.ToLower());
                if (dbClothes != null)
                {
                    return dbClothes;
                }
                else
                {
                    throw new ExceptionsMessage();
                }
            }
            catch (ExceptionsMessage)
            {
                Console.WriteLine(ExceptionsMessage.ClothesNotFoundTypeMessage);
                return null;
            }
            
        }

        
    }
}
