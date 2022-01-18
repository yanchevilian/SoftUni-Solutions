using System;

namespace Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double result = 0.0d;
            string alphabetic = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < inputArr.Length; i++)
            {
                string currentWord = inputArr[i];
                char firstLetter = currentWord[0];
                char lastLetter = currentWord[currentWord.Length - 1];

                double numberOfCurrentWord = double.Parse(currentWord.Substring(1, currentWord.Length - 2));

                int firstLetterIndex = alphabetic.IndexOf(char.ToUpper(firstLetter));
                int secondLetterIndex = alphabetic.IndexOf(char.ToUpper(lastLetter));

                if ((int)firstLetter >= 65 && (int)firstLetter <= 90)
                {
                    numberOfCurrentWord = numberOfCurrentWord / (firstLetterIndex + 1);
                }
                else
                {
                    numberOfCurrentWord = numberOfCurrentWord * (firstLetterIndex + 1);
                }

                if ((int)lastLetter>= 65 && (int)lastLetter <= 90)
                {
                    numberOfCurrentWord = numberOfCurrentWord - (secondLetterIndex + 1);
                }
                else
                {
                    numberOfCurrentWord = numberOfCurrentWord + (secondLetterIndex + 1);
                }
                result += numberOfCurrentWord;
            }
            Console.WriteLine($"{result:F2}");
        }
    }
}
