using System;

namespace _3._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCommand = Console.ReadLine();
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            if (inputCommand == "add")
            {
                AddNumbers(firstNumber, secondNumber);
            }
            else if (inputCommand == "subtract")
            {
                SubtractNumbers(firstNumber, secondNumber);
            }
            else if (inputCommand == "divide")
            {
                DivideNumbers(firstNumber, secondNumber);
            }
            else if (inputCommand == "multiply")
            {
                MultiplyNumber(firstNumber, secondNumber);
            }
         }

        private static void MultiplyNumber(double firstNumber, double secondNumber)
        {
            Console.WriteLine($"{firstNumber * secondNumber}");
        }

        private static void DivideNumbers(double firstNumber, double secondNumber)
        {
            double result = firstNumber / secondNumber;
            Console.WriteLine($"{Math.Abs(result)}");
        }

        private static void SubtractNumbers(double firstNumber, double secondNumber)
        {
            Console.WriteLine($"{firstNumber - secondNumber}");
        }

        private static void AddNumbers(double firstNum, double secondNum)
        {
            Console.WriteLine($"{firstNum + secondNum}");
        }
    }
}
