using System;
using System.Numerics;
using System.Security.Cryptography;

namespace _2._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorialNumber = int.Parse(Console.ReadLine());
            BigInteger n = 1;

            for (int i = 2; i <= factorialNumber; i++)
            {
                n *= i;
            }
            Console.WriteLine(n);
        }
    }
}
