using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    class People
    {
        public string Name { get; set; }
        public string NameProduct { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return ($"{Name}: {NameProduct} - {Price:F2}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z][a-z]+)%[^%$.|]*?<(?<nameProduct>\w+)>[^%$.|]*?\|(?<count>\d+)\|[^%$.|]*?(?<price>\d+.?\d*)\$";
            List<People> allPeople = new List<People>();

            string input = Console.ReadLine();
            double totalSum = 0.0d;

            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);
                double currentPrice = 0;
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string nameProduct = match.Groups["nameProduct"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    currentPrice = count * price;
                    totalSum += currentPrice;

                    allPeople.Add(new People{ Name = name, NameProduct = nameProduct, Price = currentPrice });
                }

                input = Console.ReadLine();
            }
            foreach (var people in allPeople)
            {
                Console.WriteLine(people);
            }
            Console.WriteLine($"Total income: {totalSum:F2}");
        }
    }
}
