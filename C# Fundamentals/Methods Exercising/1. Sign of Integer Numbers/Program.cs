using System;

namespace _1._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintSignOfNumber(number);
        }

        private static void PrintSignOfNumber(int currentNumber)
        {
            if (currentNumber > 0)
            {
                Console.WriteLine($"The number {currentNumber} is postiive.");
            }
            else if (currentNumber < 0)
            {
                Console.WriteLine($"The number {currentNumber} is negative.");
            }
            else if (currentNumber == 0)
            {
                Console.WriteLine($"The number {currentNumber} is zero.");
            }
        }
    }
}
