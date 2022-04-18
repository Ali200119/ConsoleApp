using System;

namespace ComicbooksApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("-------Welcome to your ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Comicbook ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Library");
            Console.ResetColor();
            Console.WriteLine("!-------");
        }
    }
}
