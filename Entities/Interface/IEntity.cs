using System;
namespace Entities.Interface
{
    public interface IEntity
    {
        public int RefId { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }

    }
}
