using System;
using System.Collections.Generic;

namespace _4._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> products = new Dictionary<string, List<decimal>>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                if (name.ToLower() == "buy")
                {
                    break;
                }
                decimal price = decimal.Parse(input[1]);
                int quantity = int.Parse(input[2]);
                if (!products.ContainsKey(name))
                {
                    products.Add(name, new List<decimal> { price, quantity });
                }
                else
                {
                    products[name][0] = price;
                    products[name][1] += quantity;
                }
            }
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} -> {product.Value[0] * product.Value[1] :f2}");
            }
        }
    }
}
