using System;

namespace _6._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = FindTheMiddleSymbols(input);
            Console.WriteLine(result);
        }

        private static string FindTheMiddleSymbols(string input)
        {
            string newString = "";
            if (input.Length % 2 == 0)
            {
                newString += input.Substring(input.Length / 2 - 1, input.Length / 2 - input.Length / 2 + 2);
            }
            else
            {
                newString += input.Substring(input.Length / 2, input.Length / 2 - input.Length / 2 + 1);
            }
            return newString;
        }
    }
}
