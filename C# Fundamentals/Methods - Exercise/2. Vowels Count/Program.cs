using System;
using System.Linq;

namespace _2._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int result = FindTheNumberOfVowels(input);
            Console.WriteLine(result);
        }

        private static int FindTheNumberOfVowels(string input)
        {
            int counter = 0;
            foreach (var currentSymbol in input)
            {
                if (currentSymbol == 'a' || currentSymbol == 'A')
                {
                    counter++;
                }
                else if (currentSymbol == 'e' || currentSymbol == 'E')
                {
                    counter++;
                }
                else if (currentSymbol == 'o' || currentSymbol == 'O')
                {
                    counter++;
                }
                else if (currentSymbol == 'i' || currentSymbol == 'I')
                {
                    counter++;
                }
                else if (currentSymbol == 'u' || currentSymbol == 'U')
                {
                    counter++;
                }
            }
            return counter;

            
        }
    }
}
