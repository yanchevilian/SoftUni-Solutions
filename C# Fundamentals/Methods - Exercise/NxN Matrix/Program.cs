using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = PrintNumberInRow(number);
        }

        private static int PrintNumberInRow(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(number + " ");
                }
            }
            return number;
        }
    }
}
