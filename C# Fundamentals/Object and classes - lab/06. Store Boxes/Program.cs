using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> allBoxes = new List<Box>();

            while (input != "end")
            {
                string[] inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string serialNumber = inputArr[0];
                string itemName = inputArr[1];
                int itemQuantity = int.Parse(inputArr[2]);
                double itemPrice = double.Parse(inputArr[3]);

                allBoxes.Add(new Box
                {
                    SerialNumber = serialNumber,
                    ItemQuantity = itemQuantity,
                    PriceForABox = itemPrice,
                    Item = new Item
                    {
                        Name = itemName,
                        Price = itemPrice * itemQuantity
                    }
                });
                input = Console.ReadLine();
            }

            foreach (Box currentBox in allBoxes.OrderByDescending(x => x.Item.Price).ToList())
            {
                Console.WriteLine($"{currentBox.SerialNumber}");
                Console.WriteLine($"-- {currentBox.Item.Name} – ${currentBox.PriceForABox:F2}: {currentBox.ItemQuantity}");
                Console.WriteLine($"-- ${currentBox.Item.Price:F2}");
            }
        }
    }
    class Box
    {
        //public Box()
        //{
        //    Item = new Item();
        //}
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForABox { get; set; }
    }
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
