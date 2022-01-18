﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                                           .Split()
                                           .Select(int.Parse)
                                           .ToList();

            List<int> secondPlayer = Console.ReadLine()
                                           .Split()
                                           .Select(int.Parse)
                                           .ToList();

            while (firstPlayer.Count != 0 && secondPlayer.Count != 0)
            {
                int firstPlayerCard = firstPlayer[0];
                int secondPlayerCard = secondPlayer[0];

                if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayer.Add(firstPlayerCard);
                    firstPlayer.Add(secondPlayerCard);
                }
                else if (secondPlayerCard > firstPlayerCard)
                {
                    secondPlayer.Add(secondPlayerCard);
                    secondPlayer.Add(firstPlayerCard);
                }
                firstPlayer.RemoveAt(0);
                secondPlayer.RemoveAt(0);
            }
            if (firstPlayer.Count > secondPlayer.Count)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
            }
        }
    }
}
