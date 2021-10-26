using System;
namespace Utilies
{
    public class ExceptionsMessage: Exception
    {
        public static string ClothesNotAddMessage = "Clothes cannot add";
        public static string ClothesNotDeleteMessage = "Clothes cannot delete";
        public static string ClothesNotUpdateMessage = "Clothes cannot update";
        public static string ClothesNotFoundMessage = "Clothes cannot find RefId";
        public static string ClothesNotFoundTypeMessage = "Clothes cannot find Type";
        public static string DressNotFoundMessage = "Dress not found";
        public ExceptionsMessage(string msg):base(msg)
        {
            
        }
        public ExceptionsMessage()
        {

        }
    }
}
