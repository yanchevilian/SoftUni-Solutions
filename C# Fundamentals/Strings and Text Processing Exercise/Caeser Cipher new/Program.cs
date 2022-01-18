using System;

namespace Caeser_Cipher_new
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string newText = "";

            for (int i = 0; i < text.Length; i++)
            {
                char currentSymbol = text[i];
                char newSymbol = (char)(currentSymbol + 3);

                text = text.Replace(text[i], newSymbol);
            }
            Console.WriteLine(text);
        }
    }
}
