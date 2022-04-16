using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    internal interface IComicbook
    {
        Comicbook Create(Comicbook comicbook);
        Comicbook Update(int Id, Comicbook comicbook);
        Comicbook Delete(int Id);
        Comicbook GetComicbook(string name);
    }
}
