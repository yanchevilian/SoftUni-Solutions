using System;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<item>[A-Za-z]+)<<(?<price>\d+.?\d+)!(?<quantity>\d+)\b";
            Regex reg = new Regex(pattern);
            string input = Console.ReadLine();

            Console.WriteLine("Bought furniture:");
            double totalSum = 0;

            while (input != "Purchase")
            {
                Match match = reg.Match(input);

                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    double price = double.Parse(match.Groups[2].Value);
                    int quantity = int.Parse(match.Groups[3].Value);
                    Console.WriteLine(name);

                    double currentTotalSum = price * quantity;

                    totalSum += currentTotalSum;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total money spend: {totalSum:F2}");
        }
    }
}
