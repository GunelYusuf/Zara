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
               Category IsExist = categoryRepository.Get(g => g.categoryName == category.categoryName);
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


        public Category Delete(string category)
        {
            try
            {
                Category dbCategory = categoryRepository.Get(g => g.categoryName == category);
                if (dbCategory != null)
                {
                    categoryRepository.Delete(dbCategory);
                    return dbCategory;
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

        public Category Get(string name)
        {
            try
            {
                Category dbCategory = categoryRepository.Get(g => g.categoryName.ToLower() == name.ToLower());
                if (dbCategory != null)
                {
                    return dbCategory;
                }
                else
                {
                    return null;
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
