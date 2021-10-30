using System;
using Business.Services;
using Console_Application.Controller;
using Entities.Models;
using Utilies.Helper;

namespace Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            ClothesController clothesController = new ClothesController();
            CategoryController categoryController = new CategoryController();
            KindController kindController = new KindController();
            Helper.ChangeTextColor(ConsoleColor.Magenta, "Welcome Zara");
            while (true)
            {
                ShowMenu();
                string selectedMenu = Console.ReadLine();
                int menu;
                bool isTrue = int.TryParse(selectedMenu, out menu);
                if (isTrue && menu >= 1 && menu <= 11)
                {
                    switch (menu)
                    {
                        case (int)Helper.Menu.CreateCategory:
                            categoryController.Create();
                            break;
                        case (int)Helper.Menu.CreateClothes:
                            clothesController.Create();
                            break;
                        case (int)Helper.Menu.CreateKind:
                            kindController.Create();
                            break;
                        case (int)Helper.Menu.GetAllCategory:
                            categoryController.GetAllCategory();
                            break;
                        case (int)Helper.Menu.GetAllClothes:
                            clothesController.GetAllClothes();
                            break;
                        case (int)Helper.Menu.DeleteCategory:
                            categoryController.DeleteCategory();
                            break;
                        case (int)Helper.Menu.GetAllKind:
                            kindController.GetAllKind();
                            break;
                        case (int)Helper.Menu.DeleteKind:
                            kindController.DeleteKind();
                            break;
                        case (int)Helper.Menu.UpdateCategory:
                            categoryController.Update();
                            break;
                            //case (int)Helper.Menu.DeleteClothes:
                            //    clothesController.GetAllClothes();
                            //    clothesController.DeleteClothes();
                            //    break;
                            //case (int)Helper.Menu.GetClotheswithRefId:
                            //    clothesController.Get();
                            //    break;
                            //case (int)Helper.Menu.GetClotheswithType:
                            //    clothesController.GeT();
                            //    break;

                            //case (int)Helper.Menu.GetAllQuantity:
                            //    clothesController.GetAllQuantity();
                            //    break;

                    }
                }
                else if(menu==0)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkMagenta, "Bye!");
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkRed, "Please correct select section");
                }

                  
               
            }
        }

        static void ShowMenu()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "1-Create Category,2-Create Clothes,3- Create Kind,4-All Category,5-All Clothes,6-Delete Category,7-All Kinds,8-Delete Kind,9-Update Category");
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Select option: ");
        }
    }
}
