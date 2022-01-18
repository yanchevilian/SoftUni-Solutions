using System;
using System.Collections.Generic;
using System.Linq;
//using System.Linq;

namespace _6._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command?.ToLower() != "end")
            {
                string[] inputArr = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = inputArr[0];
                string studentName = inputArr[1];

                if (courses.ContainsKey(courseName) == false)
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(studentName);

                command = Console.ReadLine();
            }
            foreach (var students in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{students.Key}: {students.Value.Count}");

                foreach (var item in students.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
