using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repositories
{
    internal class LibraryRepository : IRepository<Library>
    {
        public bool Create(Library entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Library entity)
        {
            throw new NotImplementedException();
        }

        public List<Library> GetAll(Predicate<Library> filter = null)
        {
            throw new NotImplementedException();
        }

        public Library GetOne(Predicate<Library> filter = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Library entity)
        {
            throw new NotImplementedException();
        }
    }
}
