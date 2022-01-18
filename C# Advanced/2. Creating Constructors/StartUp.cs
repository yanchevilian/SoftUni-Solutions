using System;

namespace DefiningClasses
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            var firstPerson = new Person();
            var secondPerson = new Person(24);
            var thirdPerson = new Person("Gosho", 25);

            Console.WriteLine($"FirstPerson ->\nName: {firstPerson.Name}\nAge: {firstPerson.Age}");
            Console.WriteLine($"SecondPerson ->\nName: {secondPerson.Name}\nAge: {secondPerson.Age}");
            Console.WriteLine($"ThirdPerson ->\nName: {thirdPerson.Name}\nAge: {thirdPerson.Age}");
        }
    }
}
