using System;
using Utilities.Helpler;

namespace ComicbooksApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("-------Welcome to your ");
            Extention.TextColorWithoutL(ConsoleColor.Red, "Comicbook ");
            Extention.TextColorWithoutL(ConsoleColor.Blue, "Library");
            Console.WriteLine("!-------");
        }
    }
}
