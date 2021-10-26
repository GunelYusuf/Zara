using Entities.Interface;

namespace Entities.Models
{
    public class Dress: IEntity
    {
        public int RefId { get; set; }

        public int Size { get; set; }

        public int Quantity { get; set; }

        public Clothes Clothes { get; set; }
    }
}
