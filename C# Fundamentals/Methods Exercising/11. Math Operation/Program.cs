using System;

namespace _11._Math_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());

            Calculate(firstNumber, @operator, secondNumber);
        }

        private static double Calculate(double firstNumber, string @operator, double secondNumber)
        {
            double result = 0;

            switch (@operator)
            {
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = Math.Abs(firstNumber - secondNumber);
                    break;
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
