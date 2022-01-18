using System;

namespace _8._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double factorialFromFristNumber = CalculateFactorial(firstNumber);
            double factorialFromSecondNumber = CalculateSecondFactorial(secondNumber);

            double totalResult = factorialFromFristNumber / factorialFromSecondNumber;

            Console.WriteLine($"{totalResult:F2}");
        }
        private static double CalculateFactorial(double firstNumber)
        {
            double resultFromFirstNumber = 1;
            for (double i = 1; i <= firstNumber; i++)
            {
                resultFromFirstNumber = resultFromFirstNumber * i;
            }
            return resultFromFirstNumber;
        }
        private static double CalculateSecondFactorial(double secondNumber)
        {
            double resultFromSecondNumber = 1;
            for (double i = 1; i <= secondNumber; i++)
            {
                resultFromSecondNumber = resultFromSecondNumber * i;
            }
            return resultFromSecondNumber;
        }
    }
}
