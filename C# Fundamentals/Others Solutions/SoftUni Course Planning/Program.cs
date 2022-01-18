using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] command = Console.ReadLine()
                .Split(":",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (command[0].ToLower() != "course start")
            {
                if (command[0].ToLower() == "add")
                {
                    if (lessons.Contains(command[1]))
                    {
                        continue;
                    }
                    else
                    {
                        lessons.Add(command[1]);
                    }
                }
                else if (command[0].ToLower() == "insert")
                {
                    if (lessons.Contains(command[1]))
                    {
                        continue;
                    }
                    else
                    {
                        int currentIndex = int.Parse(command[2]);
                        lessons.Insert(currentIndex, command[1]);
                    }
                }
                else if (command[0].ToLower() == "remove")
                {
                    if (lessons.Contains(command[1]))
                    {
                        continue;
                    }
                    else
                    {
                       lessons.Remove(command[1]);
                    }
                }
                else if (command[0].ToLower() == "swap")
                {
                    string firstLesson = command[1];
                    string secondLesson = command[2];
                    if (lessons.Contains(firstLesson) && lessons.Contains(secondLesson))
                    {
                        
                    }
                    else
                    {
                        continue;
                    }
                }
                command = Console.ReadLine()
                .Split(":", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
        }
    }
}
