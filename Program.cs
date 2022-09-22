using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _1._Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(Filter)
                .OrderBy(x => x)
                .ToList();

            Console.WriteLine(string.Join(", ", numbers));
        }

        static bool Filter(int number)
        {
            return number % 2 == 0;
        }
    }
}