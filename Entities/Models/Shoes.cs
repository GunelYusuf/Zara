
using Entities.Interface;

namespace Entities.Models
{
    public class Shoes:IEntity
    {
        public int Size { get; set; }

        public int RefId { get; set; }

        public string Type { get; set;}
    }
}
