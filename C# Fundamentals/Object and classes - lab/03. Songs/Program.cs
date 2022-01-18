﻿//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace _03._Songs
//{
//    class Song
//    {
//        public string TypeList { get; set; }
//        public string Name { get; set; }
//        public string Time { get; set; }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int countPlaylist = int.Parse(Console.ReadLine());
//            List<Song> allSongs = new List<Song>();
//            for (int i = 0; i < countPlaylist; i++)
//            {
//                string[] playlistArray = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries);
//                string typeList = playlistArray[0];
//                string name = playlistArray[1];
//                string time = playlistArray[2];

//                allSongs.Add(new Song { TypeList = typeList, Name = name, Time = time });
//            }
//            string command = Console.ReadLine();
//            if (command == "Type List")
//            {
//                foreach (Song typeList in allSongs)
//                {
//                    Console.WriteLine(typeList.TypeList);
//                }
//            }
//            else if (command == "all")
//            {

//            }
//        }
//    }
//}
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
                    Console.WriteLine(song.TypeList);
                }
            }
            else
            {
                //foreach (Song song in songs)
                //{
                //    if (song.TypeList == typeList)
                //    {
                //        Console.WriteLine(song.TypeName);
                //    }
                //}
                List<Song> filteredSongs = songs.Where(s => s.TypeList == typeList).ToList();

                foreach (Song song in filteredSongs)
                {
                    Console.WriteLine(song.TypeList);
                }
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
