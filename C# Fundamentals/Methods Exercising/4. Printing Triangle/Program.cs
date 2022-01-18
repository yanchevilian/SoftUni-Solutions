using System;

namespace _4._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }

        private static void PrintTriangle(int number)
        {
            PrintHeadOfTriangle(number);
            PrintBottomOfTriangle(number);
        }

        private static void PrintBottomOfTriangle(int number)
        {
            for (int i = number - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        private static void PrintHeadOfTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                PrintLine(1, i);
            }
        }
        
        private static void PrintLine(int start, int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
