using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> integers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] commandArr = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string currentCommand = commandArr[0];

                if (currentCommand == "reverse")
                {
                    int count = int.Parse(commandArr[commandArr.Length - 1]);
                    int index = int.Parse(commandArr[2]);
                    integers.Reverse(index, count);
                }
                else if (currentCommand == "sort")
                {
                    int count = int.Parse(commandArr[commandArr.Length - 1]);
                    int index = int.Parse(commandArr[2]);
                    integers.Sort(index, count, default);
                }
                else if (currentCommand == "remove")
                {
                    int count = int.Parse(commandArr[1]);
                    integers.RemoveRange(0, count);
                }
                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine(string.Join(", ",integers));
        }
    }
}
