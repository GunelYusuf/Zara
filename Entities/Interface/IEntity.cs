using System;
namespace Entities.Interface
{
    public interface IEntity
    {
        public int RefId { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }

    }
}
