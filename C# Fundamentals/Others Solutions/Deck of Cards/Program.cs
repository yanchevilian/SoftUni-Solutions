using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> vehicles = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                string[] currentCommandArr = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string currentCommand = currentCommandArr[0].ToLower();

                if (currentCommand == "add")
                {
                    string currentVehicleName = currentCommandArr[1];
                    if (vehicles.Contains(currentVehicleName))
                    {
                        Console.WriteLine("Card is already bought");
                    }
                    else
                    {
                        vehicles.Add(currentVehicleName);
                        Console.WriteLine("Card successfully bought");
                    }
                }
                else if (currentCommand == "remove")
                {
                    string currentVehicleName = currentCommandArr[1];
                    if (vehicles.Contains(currentVehicleName))
                    {
                        vehicles.Remove(currentVehicleName);
                        Console.WriteLine("Card successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                else if (currentCommand == "remove at")
                {
                    int index = int.Parse(currentCommandArr[1]);
                    if (index >= 0 && (index < vehicles.Count - 1))
                    {
                        vehicles.RemoveAt(index);
                        Console.WriteLine("Card successfully sold");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                        continue;
                    }
                }
                else if (currentCommand == "insert")
                {
                    int index = int.Parse(currentCommandArr[1]);
                    string vehicleName = currentCommandArr[2];

                    if (index >= 0 && (index < vehicles.Count - 1))
                    {
                        if (!vehicles.Contains(vehicleName))
                        {
                            vehicles.Insert(index, vehicleName);
                            Console.WriteLine("Card successfully bought");
                        }
                        else
                        {
                            Console.WriteLine("Card is already bought");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }
            Console.WriteLine(string.Join(", ",vehicles));
        }
    }
}
