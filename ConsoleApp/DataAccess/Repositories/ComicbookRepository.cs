using DataAccess;
using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;

namespace DataAccess.Repositories
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
            return filter == null ? DataContext.Comicbooks[0] :
                DataContext.Comicbooks.Find(filter);
        }

        public bool Update(Comicbook entity)
        {
            Comicbook isExists = GetOne(c => c.Name == entity.Name);
            isExists = entity;
            return true;
        }
    }
}