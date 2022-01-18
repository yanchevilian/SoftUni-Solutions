using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                       .Select(int.Parse)
                                       .ToList();

            int maxPassengersInEachWagon = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<int> numbersFromInput = new List<int>();

            while (command[0].ToLower() != "end")
            {
                if (command[0].ToLower() == "add")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else
                {
                    int currentInteger = int.Parse(command[0]);
                    numbersFromInput.Add(currentInteger);
                }
                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < numbersFromInput.Count; j++)
                {
                    if (numbers[i] + numbersFromInput[j] <= maxPassengersInEachWagon)
                    {
                        numbers[i] = numbers[i] + numbersFromInput[j];
                        numbersFromInput.RemoveAt(j);
                        j--;
                    }
                }
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
