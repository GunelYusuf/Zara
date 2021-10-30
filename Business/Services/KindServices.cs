using System;
using System.Collections.Generic;
using Business.Interfaces;
using DataAccses.Repository;
using Entities.Models;
using Utilies;

namespace Business.Services
{
    public class KindServices: IKind
    {
        public KindRepository kindRepository { get; set; }
        private static int count { get; set; }
        public KindServices()
        {
            kindRepository = new KindRepository();
        }

        public Kind Create(Kind kind)
        {
            try
            {
                kind.RefId = count;
                Kind IsExist = kindRepository.Get(g => g.kindName == kind.kindName);
                if (IsExist != null) return null;
                kindRepository.Create(kind);
                count++;
                return kind;
            }
            catch (ExceptionsMessage)
            {
                throw new ExceptionsMessage(ExceptionsMessage.ClothesNotAddMessage);
            }
        }

        public Kind Update(int RefId, Kind kind)
        {
            throw new NotImplementedException();
        }

        public Kind Delete(int RefId)
        {
            throw new NotImplementedException();
        }

        public Kind Get(string kind)
        {
            try
            {
                Kind dbKind = kindRepository.Get(g => g.kindName.ToLower() == kind.ToLower());
                if (dbKind != null)
                {
                    return dbKind;
                }
                else
                {
                    return null;
                }
            }
            catch (ExceptionsMessage)
            {
                Console.WriteLine(ExceptionsMessage.ClothesNotFoundTypeMessage);
                return null;
            }
        }

        public List<Kind> GetAll()
        {
            return kindRepository.GetAll();
        }

        public List<Kind> GetAll(int Quantity)
        {
            throw new NotImplementedException();
        }
    }
}
