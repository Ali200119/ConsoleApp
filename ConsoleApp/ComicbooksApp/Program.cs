using System;
using Utilities.Helpler;

namespace ComicbooksApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("-------Welcome to your ");
            Extention.TextColorWithoutL(ConsoleColor.Red, "Comicbook ");
            Extention.TextColorWithoutL(ConsoleColor.Blue, "Library");
            Console.WriteLine("!-------");


            int menu1;
            do
            {
                Extention.TextColorWithL(ConsoleColor.Green, "1. Create library\n" +
                    "2. Update library\n" +
                    "3. Delete library\n" +
                    "4. Get library\n" +
                    "0. Quit");

                menu1 = int.Parse(Console.ReadLine());

                switch (menu1)
                {
                    case 1:
                        {
                            string name = Console.ReadLine();
                            string 
                        }
                    
                    default:
                        {
                            Extention.TextColorWithL(ConsoleColor.Red, "Please enter 1, 2, 3, 4 or 0");
                            break;
                        }
                }
            } while (menu1 >= 1 && menu1 <= 4);
        }
    }
}
