using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class ConsoleApp
    {

        public static void Order()
        {
            double Money = 0.0;
            Console.Write("Please, give me money: ");
            string money = Console.ReadLine();
            double.TryParse(money, out Money);
            Console.WriteLine("Press 1 to find for Author");
            Console.WriteLine("Press 2 to find for Genre");
            Console.WriteLine("Press 3 to find for Album");
            string a = Console.ReadLine();
            switch (a)
            {
                case "1":
                    Console.WriteLine("Enter the Name");
                    string A = Console.ReadLine();
                    Filtr.Authors(A, Money);
                    break;

                case "2":
                    Console.WriteLine("Enter the Name");
                    string G = Console.ReadLine();
                    Filtr.Genres(G, Money);
                    break;

                case "3":
                    Console.WriteLine("Enter the Name");
                    string Al = Console.ReadLine();
                    Filtr.Albums(Al, Money);
                    break;

                default:
                    Console.WriteLine("Wrong Number");
                    break;

            }






        }
    }
}