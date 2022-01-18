using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_Targe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                                                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                                .Select(int.Parse)
                                                .ToList();
            string command = Console.ReadLine();
            int consideredShots = 0;

            while (command.ToUpper() != "END")
            {
                string[] inputArr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string task = inputArr[0];
                int index = int.Parse(inputArr[1]);
                int value = int.Parse(inputArr[2]);

                switch (task)
                {
                    case "Shoot":
                        if (index < 0 || index >= targets.Count)
                        {
                            command = Console.ReadLine();
                            continue;
                        }
                        targets[index] -= value;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                            consideredShots++;
                        }
                        break;
                    case "Add":
                        if (index < 0 || index >= targets.Count)
                        {
                            Console.WriteLine("Invalid placement!");
                            command = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            targets.Insert(index, value);
                        }
                        break;
                    case "Strike":
                        if (index - value < 0 || index + value >= targets.Count)
                        {
                            Console.WriteLine("Strike missed!");
                            command = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            targets.RemoveRange(index - value, (value * 2) + 1);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|",targets));
        }
    }
}
