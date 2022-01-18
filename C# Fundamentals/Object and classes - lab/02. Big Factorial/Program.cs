using System;
using System.Numerics;

namespace _02._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorialNumber = 1;

            for (int i = 2; i <= number; i++)
            {
                factorialNumber *= i;
            }
            Console.WriteLine(factorialNumber);
        }
    }
}
