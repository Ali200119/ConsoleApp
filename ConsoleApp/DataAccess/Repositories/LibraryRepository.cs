using DataAccess;
using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;

namespace DataAccess.Repositories
{
    public class LibraryRepository : IRepository<Library>
    {
        public bool Create(Library entity)
        {
            DataContext.Libraries.Add(entity);
            return true;
        }

        public bool Delete(Library entity)
        {
            DataContext.Libraries.Remove(entity);
            return true;
        }

        public List<Library> GetAll(Predicate<Library> filter = null)
        {
            return DataContext.Libraries.FindAll(filter);
        }

        public Library GetOne(Predicate<Library> filter = null)
        {
            return filter == null ? DataContext.Libraries[0] :
                DataContext.Libraries.Find(filter);
        }

        public bool Update(Library entity)
        {
            Library isExists = GetOne(c => c.Name == entity.Name);
            isExists = entity;
            return true;
        }
    }
}
