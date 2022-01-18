using System;
using System.Linq;

namespace _1._Valid_Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < usernames.Length; i++)
            {
                string currentWord = usernames[i];
                if (IsValid(currentWord))
                {
                    Console.WriteLine(currentWord);
                }
            }
        }

        public static bool IsValid(string word)
        {
            return word.Length >= 3 && word.Length <= 16 && word.All(c => char.IsLetterOrDigit(c) || word.Contains("_") || word.Contains("-"));
        }
    }
}
