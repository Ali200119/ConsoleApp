using DataAccess.Interfaces;
using Entities.Models;
using System;

namespace Business
{
    public class ComicbookRepository : IRepository<Comicbook>
    {
        public bool Create(Comicbook entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Comicbook entity)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.List<Comicbook> GetAll(Predicate<string> filter = null)
        {
            throw new NotImplementedException();
        }

        public Comicbook GetOne(Predicate<int> filter = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Comicbook entity)
        {
            throw new NotImplementedException();
        }
    }
}