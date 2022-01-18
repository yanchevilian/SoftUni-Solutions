using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> PeterDictionary = new Dictionary<string, List<int>>();

            while (true)
            {
                string[] inputArr = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);

                if (inputArr[0].ToLower() == "log out")
                {
                    break;
                }

                string command = inputArr[0];
                if (command.ToLower() == "new follower")
                {
                    string name = inputArr[1];
                    if (PeterDictionary.ContainsKey(name) == false)
                    {
                        PeterDictionary.Add(name, new List<int> { 0 });
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command.ToLower() == "like")
                {
                    string name = inputArr[1];
                    int count = int.Parse(inputArr[2]);

                    if (PeterDictionary.ContainsKey(name) == false)
                    {
                        PeterDictionary.Add(name, new List<int> { count });
                    }
                    else
                    {
                        PeterDictionary[name][0] += count;
                    }
                }
                else if (command.ToLower() == "comment")
                {
                    string name = inputArr[1];

                    if (PeterDictionary.ContainsKey(name) == false)
                    {
                        PeterDictionary.Add(name, new List<int> { 1 });
                    }
                    else
                    {
                        PeterDictionary[name][0]++;
                    }
                }
                else if (command.ToLower() == "blocked")
                {
                    string name = inputArr[1];

                    if (PeterDictionary.ContainsKey(name))
                    {
                        PeterDictionary.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                }
            }
            Console.WriteLine($"{PeterDictionary.Values.Count} followers");

            foreach (var followers in PeterDictionary.OrderByDescending(x => x.Value).ThenBy(x => x.Key)) 
            {
                Console.WriteLine($"{followers.Key}: {followers.Value}");
            }

        }
    }
}
