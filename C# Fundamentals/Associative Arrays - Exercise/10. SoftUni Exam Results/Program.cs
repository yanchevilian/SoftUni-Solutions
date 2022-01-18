using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<int>> usernamePoints = new Dictionary<string, List<int>>();
            Dictionary<string, int> languageCounts = new Dictionary<string, int>();

            while (command?.ToLower() != "exam finished")
            {
                string[] cmdArr = command.Split("-", StringSplitOptions.RemoveEmptyEntries);

                string username = cmdArr[0];
                string language = cmdArr[1];
                if (language.ToLower() == "banned")
                {
                    usernamePoints.Remove(username);
                    command = Console.ReadLine();
                    continue;
                }
                int points = int.Parse(cmdArr[2]);

                if (usernamePoints.ContainsKey(username) == false)
                {
                    usernamePoints.Add(username, new List<int>());
                    usernamePoints[username].Add(points);
                }
                else
                {
                    if (usernamePoints[username][0] < points)
                    {
                        usernamePoints[username][0] = points;
                    }
                }
                if (languageCounts.ContainsKey(language) == false)
                {
                    languageCounts.Add(language, +1);
                }
                else if (languageCounts.ContainsKey(language))
                {
                    languageCounts[language] += 1;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Results:");
            foreach (var usernameResult in usernamePoints.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{usernameResult.Key} | {usernameResult.Value[0]}");
            }
            Console.WriteLine("Submissions:");
            foreach (var submissions in languageCounts.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{submissions.Key} - {submissions.Value}");
            }
        }
    }
}