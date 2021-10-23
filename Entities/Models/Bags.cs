using Entities.Interface;

namespace Entities.Models
{
    public class Bags:IEntity
    {
       
        public int RefId { get; set;}

        public int Quantity { get; set; }

        public string Type { get; set; }
      
    }
}
