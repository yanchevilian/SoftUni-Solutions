using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+([359]+)([- ])2(\2)(\d{3})(\2)(\d{4})\b";
            string phonesInputs = Console.ReadLine();

            MatchCollection numbersRegistered = Regex.Matches(phonesInputs, pattern);
            int count = 0;
            foreach (Match currentNumber in numbersRegistered)
            {
                string phoneCollection = currentNumber + ", ";
                count += 1;

                if (count == numbersRegistered.Count)
                {
                    Console.WriteLine(phoneCollection.Remove(phoneCollection.Length - 2));
                }
                else
                {
                    Console.Write(phoneCollection);
                }
            }
            Console.WriteLine();
        }
    }
}