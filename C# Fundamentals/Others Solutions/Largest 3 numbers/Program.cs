using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToList();

            int[] sortedIntegers = integers
                                  .OrderByDescending(n => n)
                                  .ToArray();

            foreach (var num in sortedIntegers)
            {
                if (sortedIntegers.Length <= 2)
                {
                    Console.Write(num + " ");
                }
                else
                {

                }
            }
        }
    }
}