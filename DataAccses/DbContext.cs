using System.Collections.Generic;
using Entities.Models;

namespace DataAccses
{
    public static class DbContext
    {
        public static List<Clothes> Clothes {get;}
        public static List<Category> Category{get;}
        

        static DbContext()
        {
            Clothes = new List<Clothes>();
            Category = new List<Category>();
        }
    }

    
}
