using System;

namespace _8._Math_power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            SumThePow(number, power);
        }

        private static double SumThePow(double number, double power)
        {
            double result = number;
            for (double i = 1; i < power; i++)
            {
                result *= number;
            }
            Console.WriteLine(result);
            return number;
        }
    }
}
