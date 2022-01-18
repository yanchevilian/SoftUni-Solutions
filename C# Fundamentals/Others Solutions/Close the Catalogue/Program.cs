using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.__Close_the_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StudentCatalogue> Catalogue = new List<StudentCatalogue>();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] cmdArr = command.Split(" ");
                string name = cmdArr[0];
                int id = int.Parse(cmdArr[1]);
                int age = int.Parse(cmdArr[2]);

                StudentCatalogue students = new StudentCatalogue(name, id, age);

                Catalogue.Add(students);
                command = Console.ReadLine();
            }
            Catalogue = Catalogue.OrderBy(x => x.Age).ToList();
            Console.WriteLine(string.Join(Environment.NewLine,Catalogue));
        }
    }
    class StudentCatalogue
    {
        public StudentCatalogue(string nameOfPerson, int iD, int age)
        {
            NameOfPerson = nameOfPerson;
            ID = iD; 
            Age = age;
        }

        public string NameOfPerson { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{NameOfPerson} with ID: {ID} is {Age} years old.";
        }
    }
}

