using System;

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
            UpdateClothes=3,
            DeleteClothes=4,
            GetClotheswithRefId=5,
            GetClotheswithType=6,
            GetAllClothes=7,
            GetClotheswithSize=8,
            GetAllQuantity=9,
           


        }
    }
}
