﻿using System;

namespace Utilies.Helper
{
    public static class Helper
    {
        public static void ChangeTextColor(ConsoleColor color,string message)
        {
           Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();

        }

     

        public enum Menu
        {
            CreateCategory=1,
            CreateClothes=2,
            CreateKind=3,
            GetAllClothes=4,
            DeleteCategory=5,
            GetAllKind=6,
            DeleteKind=7,
            Update=8,
            GetClotheswithSize=9,
            GetAllQuantity=10,
           


        }
    }
}
