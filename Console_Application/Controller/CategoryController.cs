using System;
using System.Text.RegularExpressions;
using Business.Services;
using Entities.Models;
using Utilies.Helper;

namespace Console_Application.Controller
{
    public class CategoryController
    {
        public CategoryServices categoryService { get; }
        public CategoryController()
        {
            categoryService = new CategoryServices();
        }
        public void Create()
        {
            EnterType: Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Please, Enter category of clothes: ");
            string name = Console.ReadLine();
            name.Trim();
            bool IsAlpha = Regex.IsMatch(name, "^[a-zA-Z]+$");
            if (name.Length>15)
            {
               Helper.ChangeTextColor(ConsoleColor.DarkRed, "The Name of the Category cannot exceed 15 characters");
               goto EnterType;
            }
            if (IsAlpha!=true)
            {
                Helper.ChangeTextColor(ConsoleColor.DarkRed, "Please,category cannot be empty or numeric!");
                goto EnterType;
            }
            else
            {
               Category category = new Category {categoryName=name};
               if (categoryService.Create(category) != null)
               {
                 Helper.ChangeTextColor(ConsoleColor.DarkCyan, $"{category.categoryName} is created");
                 return;
               }
               else
               {
                  Helper.ChangeTextColor(ConsoleColor.DarkMagenta, $"{category.categoryName} category already exists");
                  return;
               }
                
               
            }
            
        }

    }
}
