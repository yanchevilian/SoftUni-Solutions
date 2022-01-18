﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> allStudents = new List<Student>();
            while (command != "end")
            {
                string[] inputInformation = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = inputInformation[0];
                string lastName = inputInformation[1];
                int age = int.Parse(inputInformation[2]);
                string homeTown = inputInformation[3];

                allStudents.Add(new Student { FirstName = firstName, LastName = lastName, Age = age, HomeTown = homeTown });

                command = Console.ReadLine();
            }
            string town = Console.ReadLine();
            List<Student> filteredStudents = allStudents.Where(currentStudent => currentStudent.HomeTown == town).ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine(student.getData());
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string HomeTown { get; set; }

        public string getData()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }
    }
}
