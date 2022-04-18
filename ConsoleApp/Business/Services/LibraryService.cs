using Business.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Repositories;

namespace Business.Services
{
    public class LibraryService : ILibrary
    {
        public static int Count { get; set; }
        private LibraryRepository LibraryRepository;
        

        public LibraryService(LibraryRepository libraryRepository)
        {
            LibraryRepository = libraryRepository;
        }



        public Library Create(Library library)
        {
            library.Id = Count;
            LibraryRepository.Create(library);
            Count++;
            return library;
        }

        public Library Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Library GetLibrary(string name)
        {
            throw new NotImplementedException();
        }

        public Library Update(int Id, Library library)
        {
            throw new NotImplementedException();
        }
    }
}
