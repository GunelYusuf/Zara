using System.Collections.Generic;
using Entities.Models;

namespace Business.Interfaces
{
    public interface IBags
    {
        Bags Create(Bags bags);
        Bags Delete(int RefId);
        Bags Update(int RefId, Bags bags);
        Bags Get(string Type);
        Bags Get(int RefId);
        List<Bags> GetAll();
        List<Bags> GetAll(int Size);

    }
}
