﻿
using Entities.Interface;

namespace Entities.Models
{
    public class Clothes:IEntity
    {
       
        public int RefId { get; set; }

        public int Size { get; set; }

        public string Type{ get; set; }
    }
}
