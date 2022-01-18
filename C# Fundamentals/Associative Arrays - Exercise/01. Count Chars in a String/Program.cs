using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> occurences = new Dictionary<char, int>();

            foreach (var symbol in input)
            {
                if (symbol != ' ')
                {
                    if (occurences.ContainsKey(symbol))
                    {
                        occurences[symbol]++;
                    }
                    else
                    {
                        occurences[symbol] = 1;
                    }
                }
            }
            foreach (var c in occurences)
            {
                char currentKey = c.Key;
                int currentKeyValue = c.Value;

                Console.WriteLine($"{currentKey} -> {currentKeyValue}");
            }
        }
    }
}
