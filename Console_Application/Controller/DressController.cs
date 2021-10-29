using System;
using System.Collections.Generic;
using Business.Interfaces;
using Business.Services;
using Entities.Models;
using Utilies.Helper;

namespace Console_Application.Controller
{
    public class DressController
    {
        private DressServices dressServices { get; }
        public DressController()
        {
            dressServices = new DressServices();
        }

        public void Create()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkBlue, "Select possible Clothes Type: ");
            string clothesType = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkBlue, "Enter dress type: ");
            string type = Console.ReadLine();
            Helper.ChangeTextColor(ConsoleColor.DarkBlue, "Enter dress size: ");
            string size = Console.ReadLine();
            int Size;
            bool isTrueSize = int.TryParse(size, out Size);
            if (isTrueSize)
            {
                Dress dress = new Dress { Size = Size, Type=type};
            }
            Dress NewDre= dressServices.Create(dress,clothesType);
            if (NewDre!=null)
            {
                Helper.ChangeTextColor(ConsoleColor.DarkGreen, $"New dress is Created - {NewDre.Type} {NewDre.Size}");
                return;
            }
            Helper.ChangeTextColor(ConsoleColor.DarkRed, $"Couldn't find such as Clothes Type {clothesType}");
       
        }

        public void GetAllDressWithClothes()
        {
            Helper.ChangeTextColor(ConsoleColor.DarkBlue, "Select possible Clothes Type: ");
            string clothesType = Console.ReadLine();
            List<Clothes> dresses = dressServices.GetAll(clothesType);

            if (dresses!=null)
            {
                foreach (var item in dresses)
                {
                    Helper.ChangeTextColor(ConsoleColor.DarkBlue, $"Clothes Type{clothesType}: ");
                    Helper.ChangeTextColor(ConsoleColor.DarkGreen, $"New dress is Created - {item.Type} {item.Size}");
                    return;
                }
            }

        }
    }
}
