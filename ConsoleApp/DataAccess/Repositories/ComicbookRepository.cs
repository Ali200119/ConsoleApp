using DataAccess;
using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;

namespace Business
{
    public class ComicbookRepository : IRepository<Comicbook>
    {
        public bool Create(Comicbook entity)
        {
                DataContext.Comicbooks.Add(entity);
                return true;
        }

        public bool Delete(Comicbook entity)
        {
            DataContext.Comicbooks.Remove(entity);
            return true;
        }

        public List<Comicbook> GetAll(Predicate<Comicbook> filter = null)
        {
            return DataContext.Comicbooks.FindAll(filter);
        }

        public Comicbook GetOne(Predicate<Comicbook> filter = null)
        {
            return DataContext.Comicbooks.Find(filter);
        }

        public bool Update(Comicbook entity)
        {
            Comicbook isExists = GetOne(c => c.Name == entity.Name);
            isExists = entity;
            return true;
        }
    }
}