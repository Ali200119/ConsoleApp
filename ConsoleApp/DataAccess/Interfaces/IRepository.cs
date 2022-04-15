using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Interfaces;

namespace DataAccess.Interfaces
{
    public interface IRepository<T> where T: IEntity
    {
    }
}
