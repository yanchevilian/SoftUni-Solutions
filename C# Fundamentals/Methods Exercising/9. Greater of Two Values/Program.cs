using System;

namespace _9._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeSymbols = Console.ReadLine();

            switch (typeSymbols)
            {
                case "int":
                    int firstSymbol = int.Parse(Console.ReadLine());
                    int secondSymbol = int.Parse(Console.ReadLine());
                    GetMax(firstSymbol, secondSymbol);
                    break;
                case "char":
                    char firstSymb = char.Parse(Console.ReadLine());
                    char secondSymb = char.Parse(Console.ReadLine());
                    GetBiggerChar(firstSymb, secondSymb);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    GetBiggerString(firstString, secondString);
                    break;
            }
        }

        private static string GetBiggerString(string firstString, string secondString)
        {
            int comparison = firstString.CompareTo(secondString);
            if (comparison > 0)
            {
                Console.WriteLine(firstString);
                return firstString;
            }
            else
            {
                Console.WriteLine(secondString);
                return secondString;
            }
        }

        private static char GetBiggerChar(char firstSymb, char secondSymb)
        {
            int firstSymbCompared = Convert.ToInt32(firstSymb);
            int secondSymbCompared = Convert.ToInt32(secondSymb);
            int result = Math.Max(firstSymbCompared, secondSymbCompared);
            char charResult = Convert.ToChar(result);
            Console.WriteLine(charResult);
            return charResult;
        }

        private static int GetMax(int firstSymbol, int secondSymbol)
        {
            //if (firstSymbol == secondSymbol)
            //{
            //    Console.WriteLine("They are equals.");
            //}
            int result = Math.Max(firstSymbol, secondSymbol);
            Console.WriteLine(result);
            return result;
        }
    }
}
