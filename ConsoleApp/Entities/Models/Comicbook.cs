using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Comicbook: IEntity
    {
        public int Id;
        public string Name { get; set; }
        public int PageCount { get; set; }
        public int Price { get; set; }
        public string Genre { get; set; }
    }
}