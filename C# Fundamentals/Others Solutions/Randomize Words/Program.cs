using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: 1. Create a list of words in one line.      2. Randomize their order   3. Print each word at a separate line.

            //Tasks: 1. Create a list of words in one line and split them by space.
            // 2. Create an array of words. 
            // 3. Create a random number generator - an object rnd of type Random. 
            // 4.In a for-loop exchange each number at positions 0, 1, … words.Length - 1 by a number at random position.To generate a random number in range use rnd.Next(minValue, maxValue).Note that by definition minValue is inclusive, but maxValue is exclusive.
            // 5.Print each word in the array on new line.

            //INPUT EXAMPLE: Welcome to SoftUni and have fun learning programming

            string[] words = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int index = rnd.Next(0, words.Length - 1);
                string word = words[i];
                words[i] = words[index];
                words[index] = word;
            }
            Console.WriteLine(string.Join(Environment.NewLine,words));
        }
    }
}
