using System;
using System.Collections.Generic;
using Entities.Models;

namespace Business.Interfaces
{
    public interface IKind
    {
        Kind Create(Kind kind);
        Kind Update(int RefId, Kind kind);
        Kind Delete(string name);
        Kind Get(string Type);

        List<Kind> GetAll();
        List<Kind> GetAll(int Quantity);
    }
}
