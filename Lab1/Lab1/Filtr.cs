using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Filtr
    {



        public static void Authors(string A, double M)
        {
            foreach (Album n in Database.Albums)
            {
                foreach (Song1 s in n.Songs)
                {
                    if (A == s.Author && n.Cost < M)
                    {
                        Console.WriteLine("You can choose this song: " + s.Name);
                        Console.WriteLine("Your Choise:");
                        string Song = Console.ReadLine();
                        Song1.ChoiseOfSong(Song);
                    }
                    

                }

            }
            




        }



        public static void Albums(string A, double M)
        {
            foreach (Album n in Database.Albums)
            {
                foreach (Song1 s in n.Songs)
                {
                    if (A == n.Name && n.Cost < M)
                    {
                        Console.WriteLine("You can choose this song: " + s.Name);

                    }
                    

                }

            }
            Console.WriteLine("Your Choise:");
            string Song = Console.ReadLine();
            Song1.ChoiseOfSong(Song);




        }



        public static void Genres(string A, double M)
        {
            foreach (Album n in Database.Albums)
            {
                foreach (Song1 s in n.Songs)
                {
                    if (A == s.Genre && n.Cost < M)
                    {
                        Console.WriteLine("You can choose this song: " + s.Name);



                    }
                   


                }

            }
            Console.WriteLine("Your Choise:");
            string Song = Console.ReadLine();
            Song1.ChoiseOfSong(Song);




        }





    }
}
