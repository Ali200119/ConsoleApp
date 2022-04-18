using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Library: IEntity
    {
        public  int Id;
        public string Name { get; set; }
        public int ComicsLimit { get; set; }
    }
}