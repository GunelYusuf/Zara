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
            GetAllCategory=4,
            GetAllClothes=5,
            DeleteCategory=6,
            GetAllKind=7,
            DeleteKind=8,
            UpdateCategory=9,
            DeleteClothes = 10,
            GetAllQuantity=11,
            
           


        }
    }
}
