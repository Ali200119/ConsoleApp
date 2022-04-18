using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ILibrary
    {
        Library Create(Library library);
        Library Update(int Id, Library library);
        Library Delete(int Id);
        Library GetLibrary(string name);
        List<Library> GetAll();
    }
}
