using Business.Services;
using Entities.Models;
using System;
using Utilities.Helpler;

namespace ComicbooksApp
{
    public class Program
    {
        private static LibraryService _libraryService;
        public Program()
        {
            _libraryService = new LibraryService();
        }



        static void Main(string[] args)
        {
            Console.Write("-------Welcome to your ");
            Extention.TextColorWithoutL(ConsoleColor.Red, "Comicbook ");
            Extention.TextColorWithoutL(ConsoleColor.Blue, "Library");
            Console.WriteLine("!-------\n" +
                "");


            int menu1;
            do
            {
                Extention.TextColorWithL(ConsoleColor.Yellow, "1. Create library\n" +
                    "2. Update library\n" +
                    "3. Delete library\n" +
                    "4. Get library\n" +
                    "0. Quit");

                menu1 = int.Parse(Console.ReadLine());

                switch (menu1)
                {
                    case 1:
                        {
                            Console.Write("Please enter name of library: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter comicbook's limit: ");
                            int comicbookLimit = int.Parse(Console.ReadLine());

                            Library library = new Library()
                            {
                                Name = name,
                                ComicbookLimit = comicbookLimit
                            };

                            LibraryService libraryService = new LibraryService();
                            libraryService.Create(library);
                            Extention.TextColorWithL(ConsoleColor.Green, $"{library.Name} is created");

                            break;
                        }

                    case 0:
                        {
                            return;
                        }

                    default:
                        {
                            Extention.TextColorWithL(ConsoleColor.Red, "Please enter 1, 2, 3, 4 or 0");
                            break;
                        }
                }
            } while (menu1 >= 0 || menu1 <= 0);
        }
    }
}
