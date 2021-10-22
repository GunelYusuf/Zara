using System.Collections.Generic;
using Business.Interfaces;
using DataAccses.Repository;
using Entities.Models;

namespace Business.Services
{
    public class BagsServices : IBags
    {
        public BagsRepository bagsRepository { get; set; }
        private static int count { get; set; }
        public BagsServices()
        {
            bagsRepository = new BagsRepository();
        }
        public Bags Create(Bags bags)
        {
            bags.RefId = count;
            Bags IsExist = bagsRepository.Get(g => g.Type.ToLower() == bags.Type.ToLower());
            if (IsExist != null)
                return null;
            bagsRepository.Create(bags);
                count++;
            return bags;

        }

        public Bags Delete(int RefId)
        {
            throw new System.NotImplementedException();
        }

        public Bags Get(string Type)
        {
            throw new System.NotImplementedException();
        }

        public Bags Get(int RefId)
        {
            throw new System.NotImplementedException();
        }

        public List<Bags> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public List<Bags> GetAll(int Size)
        {
            throw new System.NotImplementedException();
        }

        public Bags Update(int RefId, Bags bags)
        {
            throw new System.NotImplementedException();
        }
    }
}
