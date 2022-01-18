using System;
using System.Collections.Generic;

namespace World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCommand = Console.ReadLine();

            while (inputCommand?.ToLower() != "travel")
            {
                string[] tokkens = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries);
            }
        }
    }
}
