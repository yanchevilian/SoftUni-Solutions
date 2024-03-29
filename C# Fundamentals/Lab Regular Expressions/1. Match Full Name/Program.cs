﻿using System;
using System.Text.RegularExpressions;

namespace _1._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+\b)";

            string input = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(input, pattern);

            foreach (Match currentName in matchedNames)
            {
                Console.Write(currentName.Success + " ");
            }

            Console.WriteLine();
        }
    }
}
