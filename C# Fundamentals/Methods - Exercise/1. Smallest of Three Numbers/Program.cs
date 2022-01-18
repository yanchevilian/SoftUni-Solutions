using System;
using System.Linq;

namespace _1._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = new int[3];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = int.Parse(Console.ReadLine());
            }

            int min = FindTheSmallestNumber(numbersArray);
            Console.WriteLine(min);
        }

        private static int FindTheSmallestNumber(int[] numbersArray)
        {
            int min = numbersArray.Min();
            return min;
        }
    }
}
