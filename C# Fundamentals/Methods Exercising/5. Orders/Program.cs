using System;

namespace _5._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0.0;

            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    SumTheTotal(quantity, price);
                    break;
                case "water":
                    price = 1.00;
                    SumTheTotal(quantity, price);
                    break;
                case "coke":
                    price = 1.00;
                    SumTheTotal(quantity, price);
                    break;
                case "snacks":
                    price = 2.00;
                    SumTheTotal(quantity, price);
                    break;
            }
        }

        private static void SumTheTotal(int quantity, double price)
        {
            double totalPrice = quantity * price;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}