using Business.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Repositories;

namespace Business.Services
{
    public class ComicbookService : IComicbook
    {
        public static int Count { get; set; }
        private ComicbookRepository ComicbookRepository;


        public ComicbookService()
        {
            ComicbookRepository = new ComicbookRepository();
        }

        public Comicbook Create(Comicbook comicbook)
        {
            comicbook.Id = Count;
            ComicbookRepository.Create(comicbook);
            Count++;
            return comicbook;
        }

        public Comicbook Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Comicbook GetComicbook(string name)
        {
            return ComicbookRepository.GetOne();
        }

        public Comicbook Update(int Id, Comicbook comicbook)
        {
            throw new NotImplementedException();
        }
    }
}
