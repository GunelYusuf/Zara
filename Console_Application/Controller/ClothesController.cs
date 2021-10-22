using System;
using Business.Services;
using Entities.Models;
using Utilies.Helper;

namespace Console_Application.Controller
{
    public class ClothesController
    {
        public ClothesServices clothesService { get; }
        public ClothesController()
        {
            clothesService = new ClothesServices();
        }
        public void Create()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter Clothes Type: ");
            string type = Console.ReadLine();
        EnterType: Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter clothes Size: ");
            string size = Console.ReadLine();
            int Size;
            bool isTrueSize = int.TryParse(size, out Size);
            if (isTrueSize)
            {
                Clothes trousers = new Clothes { Type = type, Size = Size };

                if (clothesService.Create(trousers) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkGreen, $"{trousers.Type} is created");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkMagenta, $"{trousers.Type} couldn't create");
                    return;
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.DarkRed, "Please correct Size!");
                goto EnterType;
            }
        }
        public void GetAllClothes()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "All Clothes:");
            foreach (Clothes clothes in clothesService.GetAll())
            {
                Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"{clothes.RefId}-{clothes.Type}");
            }
        }
        public void DeleteClothes()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkBlue, "Please, Enter Clothes RefId: ");
            string num = Console.ReadLine();
            int RefId;
            bool isTrueSize = int.TryParse(num, out RefId);
            if (isTrueSize)
            {
                if (clothesService.Delete(RefId) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Succesfully deleted!");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkRed, $"No such {RefId} was found");
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.DarkRed, "Please select correct format");
                return;
            }

        }

    }

}