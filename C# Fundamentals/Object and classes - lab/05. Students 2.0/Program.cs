using System;
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
                //Student student = allStudents.FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
                //if (student == null)
                //{
                //    allStudents.Add(new Student()
                //    {
                //        FirstName = firstName,
                //        LastName = lastName,
                //        Age = age,
                //        HomeTown = homeTown
                //    });
                //}
                //else
                //{
                //    student.FirstName = firstName;
                //    student.LastName = lastName;
                //    student.Age = age;
                //    student.HomeTown = homeTown;
                //}
                if (IfStudentExisting(allStudents, firstName, lastName))
                {
                    Student student = GetStudent(allStudents, firstName, lastName,age);
                }
                else
                {
                    allStudents.Add(new Student { FirstName = firstName, LastName = lastName, Age = age, HomeTown = homeTown });
                }

                command = Console.ReadLine();
            }
            string town = Console.ReadLine();
            List<Student> filteredStudents = allStudents.Where(currentStudent => currentStudent.HomeTown == town).ToList();

            foreach (Student student in filteredStudents)
            {
                Console.WriteLine(student.getData());
            }
        }

        private static Student GetStudent(List<Student> allStudents, string firstName, string lastName, int age)
        {
            Student existingStudent = null;
            foreach (Student student in allStudents)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                    existingStudent.Age = age;
                }
            }
            return existingStudent;
        }

        private static bool IfStudentExisting(List<Student> allStudents, string firstName, string lastName)
        {
            foreach (Student student in allStudents)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
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
