using System;
using System.Collections;
using System.Collections.Generic;

namespace MyLib
{
    public class Song
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }

        public  List<Artist> Artists { get; set; }


        public Song(string name, int year, Artist a)
        {
            Name = name;
            Year = year;
            Artists = new List<Artist>(1);
            Artists.Add(a);
        }

        public Song(string name, int year, List<Artist> a)
        {
            Name = name;
            Year = year;
            Artists = new List<Artist>(a);
        }

        public string ListOfArtists() 
        {
            string str = "";
            foreach (Artist a in Artists)
            {
                str += a.FirstName + " " + a.SurName + ", "; 
            }
            str = str.Remove(str.Length - 2);
            return str;
        }

    }

}
