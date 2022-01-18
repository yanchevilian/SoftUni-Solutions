using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentAcademy = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfRows * 2; i += 2)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentAcademy.ContainsKey(name) == false)
                {
                    studentAcademy.Add(name, new List<double>());
                    studentAcademy[name].Add(grade);
                }
                else
                {
                    studentAcademy[name].Add(grade);
                }
            }
            foreach (var students in studentAcademy.OrderByDescending(x => x.Value.Average()))
            {
                if (students.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{students.Key} –> {students.Value.Average():F2}");
                }
            }
        }
    }
}
