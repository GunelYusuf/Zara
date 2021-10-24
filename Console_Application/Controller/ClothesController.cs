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
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter Clothes Amount: ");
            string Amount = Console.ReadLine();
            int Size;
            int amount;
            bool IsTrueAmount = int.TryParse(Amount, out amount);
            bool isTrueSize = int.TryParse(size, out Size);
            if (isTrueSize&& IsTrueAmount)
            {
                Clothes trousers = new Clothes { Type = type,Size = Size,Quantity=amount };

                if (clothesService.Create(trousers) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkCyan, $"{trousers.Type} is created");
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
                Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"{clothes.Size}-{clothes.Type}");
            }
        }

        public void Get()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter clothes RefId: ");
            string id = Console.ReadLine();
            int ClothesId;
            bool isTrue = int.TryParse(id, out ClothesId);
            if (isTrue)
            {
                Clothes skirt = clothesService.Get(ClothesId);
                Helper.ChangeTextColor(ConsoleColor.Blue, $"{ClothesId} is {skirt.Type} and {skirt.Quantity} ");
            }
        }
        public void GeT()
        { 
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter clothes Type: ");
            string type = Console.ReadLine();
            Clothes coat = clothesService.Get(type);
            Helper.ChangeTextColor(ConsoleColor.Blue, $"{coat.Type} is {coat.RefId} and {coat.Quantity}");
        }
        public void DeleteClothes()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkBlue, "Please, Enter Clothes RefId: ");
            string num = Console.ReadLine();
            int ClothesId;
            bool isTrueSize = int.TryParse(num, out ClothesId);
            if (isTrueSize)
            {
                if (clothesService.Delete(ClothesId) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Succesfully deleted!");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkRed, $"No such {ClothesId} was found");
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.DarkRed, "Please select correct format");
                return;
            }

        }
        public void Update()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter clothes RefId: ");
            string id = Console.ReadLine();
            int RefId;
            bool isTrue = int.TryParse(id, out RefId);
            if (isTrue)
            {
                int Id = int.Parse(id);
                clothesService.Get(id);
                Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"Please,Enter new size: ");
                int size = int.Parse(Console.ReadLine());
                Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"Please,Enter new type:");
                string type = Console.ReadLine();
                Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"Please,Enter new quantity:");
                string quantity = Console.ReadLine();
                int Amount;
                bool isTrueAmount = int.TryParse(quantity, out Amount);
                Clothes jeans = new Clothes {Type = type,RefId=Id,Quantity=Amount };
                clothesService.Update(Id,jeans);
                Helper.ChangeTextColor(ConsoleColor.Blue, $"{jeans.Type} is updated ");
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"Please,Enter the correct format");
            }

        }

        public void GetAllQuantity()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter Clothes Type: ");
            string type = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter clothes Size: ");
            string size = Console.ReadLine();
            int Size;
            bool isTrue = int.TryParse(size,out Size);

            if (isTrue) 
            {
                foreach (Clothes coat in clothesService.GetAll())
                {
                    if (coat.Type == type && coat.Size == Size)
                    {
                        Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"{coat.Type} is {coat.Quantity} pieces");
                    }
                }
            }

        }
    }
}

