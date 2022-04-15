using Entities.Models;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class DataContext
    {
        public static List<Library> Libraries { get; set; }
        public static List<Comicbook> Comicbooks { get; set; }

        static DataContext()
        {
            Libraries = new List<Library>();
            Comicbooks = new List<Comicbook>();
        }
    }
}
