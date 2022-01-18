using System;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input information: Dictionary<key(word), value(List<string> synonyms of word)
            //2. n - the count of the words 
            //3. after each word, you will be given a synonym, so the count of lines you have to read from the console is 2*n
            //4. You will be receiving a word and a synonym each on a separate line like this:
            //•	{ word}
            //•	{ synonym}
            //5. If you get the same word twice, just add the new synonym to the list

            var dictionary = new Dictionary<string, List<string>>();

            int countOfWords = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfWords; i++)
            {
                string input = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (dictionary.ContainsKey(input))
                {
                    dictionary[input].Add(synonym);
                }
                else
                {
                    dictionary.Add(input, new List<string>() { synonym });
                }
            }
            foreach (var synonym in dictionary)
            {
                Console.WriteLine($"{synonym.Key} - {string.Join(", ",synonym.Value)}");
            }
        }
    }
}
