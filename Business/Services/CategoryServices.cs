using System;
using System.Collections.Generic;
using Business.Interfaces;
using DataAccses.Repository;
using Entities.Models;
using Utilies;

namespace Business.Services
{
    public class CategoryServices:ICategory

    {

        public CategoryRepository categoryRepository { get; set; }
        private static int count { get; set; }
        public CategoryServices()
        {
            categoryRepository = new CategoryRepository();
        }

        public Category Create(Category category)
        {
            try
            {
               category.RefId = count;
               Category IsExist = categoryRepository.Get(g => g.Type == category.Type);
               if (IsExist != null) return null;
               categoryRepository.Create(category);
               count++;
               return category;
            }
            catch (ExceptionsMessage)
            {
                throw new ExceptionsMessage(ExceptionsMessage.ClothesNotAddMessage);
            }
        }


        public Category Delete(int RefId)
        {
            throw new NotImplementedException();
        }

        public Category Get(string Type)
        {
            try
            {
                Category dbCategory = categoryRepository.Get(g => g.Type.ToLower() == Type.ToLower());
                if (dbCategory != null)
                {
                    return dbCategory;
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

        public List<Category> GetAll()
        {
           return categoryRepository.GetAll();
        }

        public List<Category> GetAll(int Quantity)
        {
            throw new NotImplementedException();
        }

        public Category Update(int RefId, Category type)
        {
            throw new NotImplementedException();
        }

      
    }
}
