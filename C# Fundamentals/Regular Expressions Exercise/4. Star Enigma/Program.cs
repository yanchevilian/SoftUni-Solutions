using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4._Star_Enigma
{

    class Program
    {
        static void Main(string[] args)
        {
            int messages = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> allPlanets = new Dictionary<string, List<string>>
            {
                ["Attacked"] = new List<string>(),
                ["Destroyed"] = new List<string>()
            };

            for (int i = 0; i < messages; i++)
            {
                string newMessage = "";
                string encryptedMessages = Console.ReadLine();
                string pattern = @"[STARstar]";
                MatchCollection match = Regex.Matches(encryptedMessages, pattern);
                int matchesCount = match.Count;

                foreach (var currentSymbol in encryptedMessages)
                {
                    int symbol = currentSymbol - matchesCount;
                    char symbolToChar = (char)symbol;
                    newMessage += symbolToChar;
                }
                string newPattern = @"@(?<planetName>[A-Za-z]+)[^!@>\-:]*?:(?<planetPopulation>[\d]+)[^!@>\-:]*?!(?<attackType>[A|D])![^!@>\-:]*?->(?<soldierCount>\d+)";
                Regex regex = new Regex(newPattern);
                Match matched = regex.Match(newMessage);
                if (matched.Success)
                {
                    string name = matched.Groups["planetName"].Value;
                    int planetPopulation = int.Parse(matched.Groups["planetPopulation"].Value);
                    char attackedType = char.Parse(matched.Groups["attackType"].Value);
                    int soldierCount = int.Parse(matched.Groups["soldierCount"].Value);

                    if (attackedType == 'A')
                    {
                        allPlanets["Attacked"].Add(name);
                    }
                    else if (attackedType == 'D')
                    {
                        allPlanets["Destroyed"].Add(name);
                    }
                }
            }
            foreach (var planet in allPlanets)
            {
                Console.WriteLine($"{planet.Key} planets: {planet.Value.Count}");

                foreach (var planets in planet.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planets}");
                }
            }
        }
    }
}
