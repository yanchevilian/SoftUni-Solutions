using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> namesOfParticipants = new Dictionary<string, int>();

            foreach (var name in inputNames)
            {
                namesOfParticipants.Add(name,0);
            }
            string namePattern = @"[\W\d]";
            string numberPattern = @"[\WA-Za-z]";

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                int sum = 0;
                string name = Regex.Replace(input, namePattern, "");
                string number = Regex.Replace(input, numberPattern, "");

                foreach (var currentNum in number)
                {
                    sum += int.Parse(currentNum.ToString());
                }

                if (namesOfParticipants.ContainsKey(name))
                {
                    namesOfParticipants[name] += sum;
                }
                input = Console.ReadLine();
            }
            int counter = 1;
            foreach (var rankedParticipants in namesOfParticipants.OrderByDescending(x => x.Value))
            {
                string name = counter == 1 ? "st" : counter == 2 ? "nd" : "rd";

                Console.WriteLine($"{counter++}{name} place: {rankedParticipants.Key}");

                if (counter == 4)
                {
                    break;
                }
            }
        }
    }
}
