/// Непша Илья ИУ6-71Б
/// 
/// Вариант F2

using System;
using MyLib;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            var albums = new List<Album>(3);

            albums.Add(
                new Album("All Your Love - Single", 2019,
                    new Song("All your Love", 2019,
                        new Artist("Jakob", "Ogawa"))
                ));


            var Songs1 = new List<Song>(5);
            var art1 = new Artist("Mac", "DeMarco");
            Songs1.Add(new Song("Cooking Up Something Good", 2012, art1));
            Songs1.Add(new Song("Dreaming", 2012, art1));
            Songs1.Add(new Song("Freaking Out the Neihborhood", 2012, art1));
            Songs1.Add(new Song("Annie", 2012, art1));
            Songs1.Add(new Song("Ode to Viceroy", 2012, art1));

            albums.Add(new Album("2", 2012, Songs1));


            var Songs2 = new List<Song>(2);
            var art2 = new Artist("Kedr", "Livanskiy");
            Songs2.Add(new Song("Sky Kisses", 2019, art2));
            Songs2.Add(new Song("Ivan Kupala", 2012, art2));

            albums.Add(new Album("Your Need", 2012, Songs2));


            
            foreach (Album alb in albums)
            {
                Console.WriteLine(alb.Info());
                string json = JsonSerializer.Serialize<Album>(alb);
                var filename = @".\" + alb.Name + ".json";
                System.IO.File.WriteAllText(filename, json.ToString());
            }


            Console.ReadLine();
        }
    }
}
