using System.Collections.Generic;
using Entities.Models;

namespace DataAccses
{
    public static class DbContext
    {
        public static List<Clothes> Clothes {get;}
        public static List<Shoes> Shoes {get;}
        public static List<Bags> Bags {get;}

        static DbContext()
        {
            Clothes = new List<Clothes>();
            Shoes = new List<Shoes>();
            Bags = new List<Bags>();
        }
    }

    
}
