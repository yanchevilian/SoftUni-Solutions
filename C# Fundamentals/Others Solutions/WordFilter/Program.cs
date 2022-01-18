using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(n => n.Length % 2 == 0)
                .ToList();

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
