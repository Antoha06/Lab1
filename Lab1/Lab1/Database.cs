using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Database
    {
        public static List<Album> Albums = new List<Album>();
        public static  List<Song1> Songs = new List<Song1>();


        public static void Fill()
        {
            Albums.Add(new Album("Album 1", 10));
            Albums.Add(new Album("Album 2", 20));
            Albums.Add(new Album("Album 3", 15.5));
            Albums.Add(new Album("Album 4", 2.5));




            Albums[0].Songs.Add(new Song1("Song 1", "Author1", "Jaz"));
            Albums[1].Songs.Add(new Song1("Song 2", "Author2", "Rock"));
            Albums[2].Songs.Add(new Song1("Song 3", "Author3", "Reggie"));
            Albums[3].Songs.Add(new Song1("Song 4", "Author4", "R$B"));
            Albums[3].Songs.Add(new Song1("Song 5", "Author4", "R$B"));
            Albums[3].Songs.Add(new Song1("Song 6", "Author4", "R$B"));




        }

    }
}
