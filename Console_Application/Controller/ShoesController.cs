using System;
using Business.Services;
using Entities.Models;
using Utilies.Helper;

namespace Console_Application.Controller
{
    public class ShoesController
    {
        public ShoesServices shoesService { get; }
        public ShoesController()
        {
            shoesService = new ShoesServices();
        }
        public void Create()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter Shoes Type: ");
            string type = Console.ReadLine();
            EnterType: Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter shoes Size: ");
            string size = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter Shoes Amount: ");
            string Amount = Console.ReadLine();
            int Size;
            int amount;
            bool IsTrueAmount = int.TryParse(Amount, out amount);
            bool isTrueSize = int.TryParse(size, out Size);
            if (isTrueSize && IsTrueAmount)
            {
                Shoes makasin = new Shoes { Type = type, Size = Size, Quantity = amount };

                if (shoesService.Creat(makasin) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkCyan, $"{makasin.Type} is created");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkMagenta, $"{makasin.Type} couldn't create");
                    return;
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.DarkRed, "Please correct Size!");
                goto EnterType;
            }
        }
        public void GetAllShoes()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "All Shoes:");
            foreach (Shoes shoes in shoesService.GetAll())
            {
                Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"{shoes.Size}-{shoes.Type}");
            }
        }
        public void Get()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter Shoes RefId: ");
            string id = Console.ReadLine();
            int ShoesId;
            bool isTrue = int.TryParse(id, out ShoesId);
            if (isTrue)
            {
               Shoes makasin = shoesService.Get(ShoesId);
               Helper.ChangeTextColor(ConsoleColor.Blue, $"{ShoesId} is {makasin.Type} and {makasin.Quantity} ");
            }
        }
        public void GeT()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter Shoes Type: ");
            string type = Console.ReadLine();
            Shoes makasin = shoesService.Get(type);
            Helper.ChangeTextColor(ConsoleColor.Blue, $"{makasin.Type} is {makasin.RefId} and {makasin.Quantity}");
        }
        public void DeleteClothes()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkBlue, "Please, Enter Shoes RefId: ");
            string num = Console.ReadLine();
            int ShoesId;
            bool isTrueSize = int.TryParse(num, out ShoesId);
            if (isTrueSize)
            {
                if (shoesService.Delete(ShoesId) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Succesfully deleted!");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkRed, $"No such {ShoesId} was found");
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
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter shoes RefId: ");
            string id = Console.ReadLine();
            int RefId;
            bool isTrue = int.TryParse(id, out RefId);
            if (isTrue)
            {
                int Id = int.Parse(id);
                shoesService.Get(id);
                Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"Please,Enter new size: ");
                int size = int.Parse(Console.ReadLine());
                Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"Please,Enter new type:");
                string type = Console.ReadLine();
                Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"Please,Enter new quantity:");
                string quantity = Console.ReadLine();
                int Amount;
                bool isTrueAmount = int.TryParse(quantity, out Amount);
                Shoes makasin = new Shoes { Type = type, RefId = Id, Quantity = Amount };
                shoesService.Update(Id, makasin);
                Helper.ChangeTextColor(ConsoleColor.Blue, $"{makasin.Type} is updated ");
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.Blue, $"Please,Enter the correct format");
            }

        }
        public void GetAllQuantity()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter Shoes Type: ");
            string type = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter Shoes Size: ");
            string size = Console.ReadLine();
            int Size;
            bool isTrue = int.TryParse(size, out Size);

            if (isTrue)
            {
                foreach (Shoes makasin in shoesService.GetAll())
                {
                    if (makasin.Type == type && makasin.Size == Size)
                    {
                        Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"{makasin.Type} is {makasin.Quantity} pieces");
                    }
                }
            }

        }
    }    
}
