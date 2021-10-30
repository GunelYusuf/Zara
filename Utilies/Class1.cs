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
            CreateKind=3,
            UpdateClothes=4,
            DeleteClothes=5,
            GetClotheswithRefId=6,
            GetClotheswithType=7,
            GetAllClothes=8,
            GetClotheswithSize=9,
            GetAllQuantity=10,
           


        }
    }
}
