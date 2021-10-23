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
            CreateClothes=1,
            UpdateClothes=2,
            DeleteClothes=3,
            GetClotheswithRefId=4,
            GetClotheswithType=5,
            GetAllClothes=6,
            GetClotheswithSize=7
        }
    }
}
