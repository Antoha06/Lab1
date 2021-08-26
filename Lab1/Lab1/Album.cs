using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Album
    {
        private string name;
        public List<Song1> Songs;
        private double cost;


        public string Name { get => name; set => name = value; }
        public double Cost { get => cost; set => cost = value; }


        public Album(string N, double C)
        {
            Name = N;
            Cost = C;

            Songs = new List<Song1>();

        }

        public override string ToString()
        {
            return "Album " + Name;
        }


    }
}
