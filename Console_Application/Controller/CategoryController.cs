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
            EnterType: Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Please, Enter category type: ");
            string type = Console.ReadLine();
            type.Trim();
            bool IsAlpha = Regex.IsMatch(type, "^[a-zA-Z]+$");
            if (type.Length>15)
            {
               Helper.ChangeTextColor(ConsoleColor.DarkRed, "The Name of the Type cannot exceed 15 characters");
               goto EnterType;
            }
            if (IsAlpha!=true)
            {
                Helper.ChangeTextColor(ConsoleColor.DarkRed, "Please,type cannot be empty or numeric!");
                goto EnterType;
            }
            else
            {
               Category category = new Category { Type = type };
               if (categoryService.Create(category) != null)
               {
                 Helper.ChangeTextColor(ConsoleColor.DarkCyan, $"{category.Type} is created");
                 return;
               }
               else
               {
                  Helper.ChangeTextColor(ConsoleColor.DarkMagenta, $"{category.Type} category already exists");
                  return;
               }
                
               
            }
            
        }

    }
}
