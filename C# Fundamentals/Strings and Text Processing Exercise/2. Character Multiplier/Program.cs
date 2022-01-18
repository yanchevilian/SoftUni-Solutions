using System;

namespace _2._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string firstWord = inputArr[0];
            string secondWord = inputArr[1];

            string longestWord = firstWord;
            string shortestWord = secondWord;

            if (firstWord.Length < secondWord.Length)
            {
                longestWord = secondWord;
                shortestWord = firstWord;
            }

            int total = CharMultiplier(longestWord, shortestWord);

            Console.WriteLine(total);
                                      
        }

        private static int CharMultiplier(string longerWord, string shorterWord)
        {
            int sum = 0;

            for (int i = 0; i < shorterWord.Length; i++)
            {
                int multiply = longerWord[i] * shorterWord[i];

                sum += multiply;
            }
            for (int i = shorterWord.Length; i < longerWord.Length; i++)
            {
                sum += longerWord[i];
            }

            return sum;
        }
    }
}
