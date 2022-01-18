﻿using System;
using System.Text.RegularExpressions;

namespace _3._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            string input = Console.ReadLine();

            MatchCollection datesMatched = Regex.Matches(input, pattern);

            foreach (Match match in datesMatched)
            {
                //string day = match.Groups["day"].Value;
                //string month = match.Groups["month"].Value;
                //string year = match.Groups["year"].Value;

                //Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

                Console.WriteLine("Day: {0}, Month: {1}, Year: {2}", match.Groups["day"], match.Groups["month"], match.Groups["year"]);
            }
        }
    }
}
