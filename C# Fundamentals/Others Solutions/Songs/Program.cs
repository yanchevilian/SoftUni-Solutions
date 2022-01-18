using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                                       .Split("_")
                                       .ToArray();
                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();

                song.TypeList = type;
                song.TypeName = name;
                song.Time = time;

                songs.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.TypeName);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == "typeList")
                    {
                        Console.WriteLine(song.TypeName);
                    }
                }
            }

            List<Song> filteredSongs = songs.Where(s => s.TypeList == typeList).ToList();

            foreach (Song song in filteredSongs)
            {
                Console.WriteLine(song.TypeName);
            }
        }
        class Song
        {
            public string TypeList { get; set; }
            public string TypeName { get; set; }
            public string Time { get; set; }
        }
    }
}
