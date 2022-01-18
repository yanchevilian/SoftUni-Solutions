using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;

namespace _10._Multiply_Even_By_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = GetResult(number);
            Console.WriteLine(result);
        }

        private static int GetResult(int number)
        {
            int result = GetEvenNumbers(number) * GetOddNumbers(number);
            return result;
        }

        private static int GetOddNumbers(int number)
        {
            number = Math.Abs(number);
            string input = number.ToString();
            int sumOdd = 0;
            foreach (var currentDigit in input)
            {
                int currentNumber = int.Parse(currentDigit.ToString());
                if (currentNumber % 2 != 0)
                {
                    sumOdd += currentNumber;
                }
            }
            return sumOdd;
        }

        private static int GetEvenNumbers(int number)
        {
            number = Math.Abs(number);
            string input = number.ToString();
            int sumEven = 0;
            foreach (var currentDigit in input)
            {
                int currentNumber = int.Parse(currentDigit.ToString());
                if (currentDigit % 2 == 0)
                {
                    sumEven += currentNumber;
                }
            }
            return sumEven;
        }
    }
}
