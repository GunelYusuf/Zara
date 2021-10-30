using System;
using Business.Services;
using Entities.Models;
using Utilies.Helper;

namespace Console_Application.Controller
{
    public class ClothesController
    {
        public ClothesServices clothesService { get; }
        public CategoryServices categoryServices { get; }
        public KindServices kindServices { get; }

        public ClothesController()
        {
            clothesService = new ClothesServices();
            categoryServices = new CategoryServices();
            kindServices = new KindServices();
        }
        public void Create()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Please,select the category of clothes: ");
            foreach (var item in categoryServices.GetAll())
            {
                Console.WriteLine(item.categoryName);
            }
        EnterCategory: Console.Write("Select: ");
            string category = Console.ReadLine();
            Category dbCategory = categoryServices.Get(category);
            if (dbCategory == null)
            {
                Helper.ChangeTextColor(ConsoleColor.DarkRed, "The Category you entered is not available in the list ");
                goto EnterCategory;
            }
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter Clothes Type: ");
            foreach (var item in kindServices.GetAll())
            {
                Console.WriteLine(item.kindName);
            }
        EnterType: Console.Write("Select: ");
            string kind = Console.ReadLine();
            Kind dbKind = kindServices.Get(kind);
            if (dbKind == null)
            {
                Helper.ChangeTextColor(ConsoleColor.DarkRed, "The Kind you entered is not available in the list ");
                goto EnterType;
            }

        EnterSize: Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter Clothes Size: ");
            string size = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter Clothes Amount: ");
            string Amount = Console.ReadLine();
            int Size;
            int amount;
            bool IsTrueAmount = int.TryParse(Amount, out amount);
            bool isTrueSize = int.TryParse(size, out Size);
            if (isTrueSize && IsTrueAmount)
            {
                Clothes clothes = new Clothes { Kind = kind, Size = Size, Quantity = amount, Category = category };

                if (clothesService.Create(clothes) != null)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkCyan, $"{clothes.Category} is created");
                    return;
                }
                else
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkMagenta, $"{clothes.Category} couldn't create");
                    return;
                }
            }
            else
            {
                Helper.ChangeTextColor(ConsoleColor.DarkRed, "Please correct Size!");
                goto EnterSize;
            }
        }
        public void GetAllClothes()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkYellow, "All Clothes:");
            foreach (Clothes clothes in clothesService.GetAll())
            {
                Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"The Category: {clothes.Category} Kind: {clothes.Kind} Size: {clothes.Size} Quantity: {clothes.Quantity}");
            }
        }

        //public void Get()
        //{
        //    Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter clothes RefId: ");
        //    string id = Console.ReadLine();
        //    int ClothesId;
        //    bool isTrue = int.TryParse(id, out ClothesId);
        //    if (isTrue)
        //    {
        //        Clothes skirt = clothesService.Get(ClothesId);
        //        Helper.ChangeTextColor(ConsoleColor.Blue, $"{ClothesId} is {skirt.Type} and {skirt.Quantity} ");
        //    }
        //}
        //public void GeT()
        //{ 
        //    nameof: Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter clothes Type: ");
        //    string type = Console.ReadLine();
        //    Clothes coat = clothesService.Get(type);
        //    if (coat==null)
        //    {
        //        goto nameof;
        //    }
        //    Helper.ChangeTextColor(ConsoleColor.Blue, $"{coat.Type} is {coat.RefId} and {coat.Quantity}");
        //}
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
            
            //public void Update()
            //{
            //    nameof: Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter clothes RefId: ");
            //    string id = Console.ReadLine();
            //    int RefId;
            //    bool isTrue = int.TryParse(id, out RefId);
            //    if (isTrue)
            //    {
            //        int Id = int.Parse(id);
            //        if (clothesService.Get(id)==null)
            //        {
            //            goto nameof;
            //        }
            //        Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"Please,Enter new size: ");
            //        int size = int.Parse(Console.ReadLine());
            //        Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"Please,Enter new type:");
            //        string type = Console.ReadLine();
            //        Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"Please,Enter new quantity:");
            //        string quantity = Console.ReadLine();
            //        int Amount;
            //        bool isTrueAmount = int.TryParse(quantity, out Amount);
            //        Clothes jeans = new Clothes {Type = type,RefId=Id,Quantity=Amount };
            //        clothesService.Update(Id,jeans);
            //        Helper.ChangeTextColor(ConsoleColor.Blue, $"{jeans.Type} is updated ");
            //    }
            //    else
            //    {
            //        Helper.ChangeTextColor(ConsoleColor.Blue, $"Please,Enter the correct format");
            //    }

            //}

            //public void GetAllQuantity()
            //{
            //    Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter Clothes Type: ");
            //    string type = Console.ReadLine();
            //    Helper.ChangeTextColor(ConsoleColor.DarkGreen, "Enter clothes Size: ");
            //    string size = Console.ReadLine();
            //    int Size;
            //    bool isTrue = int.TryParse(size,out Size);

            //    if (isTrue) 
            //    {
            //        foreach (Clothes coat in clothesService.GetAll())
            //        {
            //            if (coat.Type == type && coat.Size == Size)
            //            {
            //                Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"{coat.Type} is {coat.Quantity} pieces");
            //            }
            //        }
            //    }

            //}
        
    }
}

