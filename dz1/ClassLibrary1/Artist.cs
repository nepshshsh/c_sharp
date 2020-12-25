using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib
{
    public class Artist
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }

        public Artist(string Fname, string Sname)
        {
            FirstName = Fname;
            SurName = Sname;
        }
    }
}
