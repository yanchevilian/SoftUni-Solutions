using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                                       .Split("|")
                                       .ToList();

            numbers.Reverse();

            List<string> result = new List<string>();

            foreach (string currentElement in numbers)
            {
                string[] items = currentElement
                                     .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                                     .ToArray();

                foreach (string elementsToAdd in items)
                {
                    result.Add(elementsToAdd);
                 }

            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
