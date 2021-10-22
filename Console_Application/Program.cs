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
            
            Helper.ChangeTextColor(ConsoleColor.Magenta, "Welcome Zara");
            while (true)
            {
                ShowMenu();
                string selectedMenu = Console.ReadLine();
                int menu;
                bool isTrue = int.TryParse(selectedMenu, out menu);
                if (isTrue && menu >= 1 && menu <= 7)
                {
                    switch (menu)
                    {
                        case (int)Helper.Menu.CreateClothes:
                            clothesController.Create();
                            break;
                        case (int)Helper.Menu.UpdateClothes:
                            break;
                        case (int)Helper.Menu.DeleteClothes:
                            clothesController.GetAllClothes();
                            clothesController.DeleteClothes();
                            break;
                        case (int)Helper.Menu.GetClotheswithRefId:
                            break;
                        case (int)Helper.Menu.GetAllClothes:
                            clothesController.GetAllClothes();
                            break;
                        case (int)Helper.Menu.GetClotheswithSize:
                            break;
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
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "1-Create Clothes,2-Update Clothes,3-Delete Clothes,4-Get Clothes with RefId," +
                   "5-Get Clothes with Type,6-All Clothes,7-Get Clothes with Size 0-Exit");
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "Select option: ");
        }
    }
}
