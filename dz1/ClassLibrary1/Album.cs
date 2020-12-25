using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    public class Album
    {
        public  string Name { get; set; }
        public int Year { get; set; }
               
        public List<Song> Songs { get; set; }

        public Album()
        {
            Songs = new List<Song>();
        }

        public Album(string name, int year, Song s)
        {
            Name = name;
            Year = year;
            Songs = new List<Song>(1);
            Songs.Add(s);
        }

        public Album(string name, int year, List<Song> s)
        {
            Name = name;
            Year = year;
            Songs = new List<Song>(s);
        }
        
        public string ListOfSongs()
        {
            string str = "";
            foreach (Song s in Songs)
            {
                str += "  * " + s.ListOfArtists() + " - " + s.Name + "\n";
            }
            return str;
        }
        public string Info()
        {
            return Name + " / " + Year + "\n" + ListOfSongs();
        }
        
    }
}
