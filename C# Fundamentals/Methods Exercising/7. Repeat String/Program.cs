using System;
using System.Text;

namespace _7._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            ConcatenateString(input, count);
        }

        private static string ConcatenateString(string input, int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(input);
            }
            Console.WriteLine(sb);
            return sb.ToString();
        }
    }
}
