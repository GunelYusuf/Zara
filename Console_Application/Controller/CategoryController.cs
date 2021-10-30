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
            if (name.Length > 15)
            {
                Helper.ChangeTextColor(ConsoleColor.DarkRed, "The Name of the Category cannot exceed 15 characters");
                goto EnterType;
            }
            if (IsAlpha != true)
            {
                Helper.ChangeTextColor(ConsoleColor.DarkRed, "Please,category cannot be empty or numeric!");
                goto EnterType;
            }
            else
            {
                Category category = new Category { categoryName = name };
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

        public void DeleteCategory()
        {
            GetAllCategory();
            Helper.ChangeTextColor(ConsoleColor.DarkBlue, "Please, Enter Category Name: ");
            string name = Console.ReadLine();
            if (categoryService.Delete(name) != null)
            {
                Helper.ChangeTextColor(ConsoleColor.DarkGreen, $"{name} is deleted!");
                return;
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.DarkRed, $"No such {name} was found");
            }
        }

        public void GetAllCategory()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "All Category:");
            foreach (Category category in categoryService.GetAll())
            {
                Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"The Category: {category.categoryName}");
            }
        }

        public void Update()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Select The Category you want to change: ");
            foreach (var item in categoryService.GetAll())
            {
                Console.WriteLine(item.categoryName);
            }
        EnterCategory: Console.Write("Select: ");
            string category = Console.ReadLine();
            Category dbCategory = categoryService.Get(category);
            if (dbCategory == null)
            {
                Helper.ChangeTextColor(ConsoleColor.DarkRed, "The Category you entered is not available in the list ");
                goto EnterCategory;
            }
            if (categoryService.Get(category) != null)
            {
            EnterType: Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Please, Enter new category of clothes: ");
                string newName = Console.ReadLine();
                newName.Trim();
                bool IsAlpha = Regex.IsMatch(newName, "^[a-zA-Z]+$");
                if (newName.Length > 15)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkRed, "The Name of the Category cannot exceed 15 characters");
                    goto EnterType;
                }
                if (IsAlpha != true)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkRed, "Please,category cannot be empty or numeric!");
                    goto EnterType;
                }
                else
                {
                    if (categoryService.Update(category,newName) != null)
                    {
                        Helper.ChangeTextColor(ConsoleColor.DarkCyan, $"{category} category changed to {newName} category ");
                        return;
                    }
                    else
                    {
                        Helper.ChangeTextColor(ConsoleColor.DarkMagenta, $"{newName} category already exists");
                        return;
                    }

                }


            }
        }
    }
}
