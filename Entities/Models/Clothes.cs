
using Entities.Interface;

namespace Entities.Models
{
    public class Clothes:IEntity
    {
        public int RefId { get; set; }

        public int Size { get; set; }

        public int Quantity { get; set; }

        public string Kind{ get; set; }

        public string Category { get; set;}
    }
}
