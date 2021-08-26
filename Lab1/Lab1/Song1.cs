using System;

namespace Lab1
{
    public class Song1
    {
        private string name;
        private string genre;
        private string author;

        public string Genre { get => genre; set => genre = value; }
        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }

        public Song1(string N, string G, string A)
        {
            Name = N;
            Genre = G;
            Author = A;

        }

        public override string ToString()
        {
            return "Song " + Name + "; Author = " + Author + ";Genre" + Genre;
        }


        public static void ChoiseOfSong(string S)
        {
            foreach (Album n in Database.Albums)
            {
                foreach (Song1 s in n.Songs)
                {
                    if (S == s.Name)
                    {
                        Console.WriteLine(s.Name+ " "+ s.Author + "  la la la la");

                    }

                    else
                    {
                        Console.WriteLine("Wrong Name");
                    }

                }

            }
        }

    }

    

}
