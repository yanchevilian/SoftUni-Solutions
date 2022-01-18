using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputTokkens = Console.ReadLine()
                                            .Split("@", StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToList();

            string command = Console.ReadLine();
            int jumpLength = 0;
            while (command?.ToLower() != "love!")
            {
                List<string> inputArgument = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

                jumpLength += int.Parse(inputArgument[1]);

                if (jumpLength > inputTokkens.Count - 1)
                {
                    jumpLength = 0;
                }

                if (inputTokkens[jumpLength] == 0)
                {
                    Console.WriteLine($"Place {jumpLength} already had Valentine's day.");
                }
                else
                {

                    inputTokkens[jumpLength] -= 2;
                    if (inputTokkens[jumpLength] == 0)
                    {
                        Console.WriteLine($"Place {jumpLength} has Valentine's day.");
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {jumpLength}.");
            int counter = 0;
            for (int i = 0; i < inputTokkens.Count; i++)
            {
                if (inputTokkens[i] == 0)
                {
                    counter++;
                }
            }
            if (counter == inputTokkens.Count)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {inputTokkens.Count - counter} places.");
            }
        }
    }
}
