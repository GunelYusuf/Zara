using System.Collections.Generic;
using Entities.Models;

namespace DataAccses
{
    public static class DbContext
    {
        public static List<Clothes> Clothes {get;}
        public static List<Category> Category{get;}
        public static List<Kind> Kind {get;}
        

        static DbContext()
        {
            Clothes = new List<Clothes>();
            Category = new List<Category>();
            Kind = new List<Kind>();
        }
    }

    
}
