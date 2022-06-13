using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Songs
{
    class Song
    {
        public string Name { get; set; }
        public string TypeList { get; set; }
        public string Time { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSong = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < numberOfSong; i++)
            {
                string[] tokens = Console.ReadLine()
               .Split('_',StringSplitOptions.RemoveEmptyEntries).ToArray();
                string typeList = tokens[0];
                string name = tokens[1];
                string time = tokens[2];
                Song newSong = new Song()
                {
                    Name = name,
                    TypeList = typeList,
                    Time = time

                };
                songs.Add(newSong);
            }
            string typeListSearsch = Console.ReadLine();
            if (typeListSearsch == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filterSongs = songs.FindAll(song => song.TypeList == typeListSearsch);
                foreach (Song song in filterSongs)
                {
                    Console.WriteLine(song.Name);
                }

            }

        }
    }
}
