using System;
using System.Collections.Generic;
using System.Linq;

namespace Shoot_for_the_win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int consideredShots = 0;

            string command = Console.ReadLine();
            while (command?.ToLower() != "end")
            {
                int index = int.Parse(command);
                if (index < 0 || index > targets.Length - 1)
                {
                    command = Console.ReadLine();
                    continue;
                }
                else
                {
                    int shotNumber = targets[index];
                    if (targets[index] == -1)
                    {
                        continue;
                    }
                    else
                    {
                        targets[index] = -1;
                        consideredShots++;
                    }

                    for (int i = 0; i < targets.Length; i++)
                    {
                        int currentTarget = targets[i];
                        if (shotNumber < currentTarget && targets[i] != -1)
                        {
                            targets[i] -= shotNumber;
                        }
                        else if (shotNumber >= currentTarget && targets[i] != -1)
                        {
                            targets[i] += shotNumber;
                        }
                    }
                    command = Console.ReadLine();
                }
            }
            Console.WriteLine($"Shot targets: {consideredShots} -> " + string.Join(" ", targets));
        }
    }
}
