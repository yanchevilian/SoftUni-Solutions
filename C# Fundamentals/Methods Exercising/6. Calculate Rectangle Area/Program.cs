using System;

namespace _6._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            SumTheArea(sideA, sideB);
        }

        private static double SumTheArea(double sideA, double sideB)
        {
            double result = sideA * sideB;
            Console.WriteLine(result);
            return result;
        }
    }
}
