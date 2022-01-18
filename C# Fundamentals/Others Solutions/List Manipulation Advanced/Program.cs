using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Schema;

namespace _6._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            string[] command = Console.ReadLine()
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                      .ToArray();

            List<int> copiedList = new List<int>(number);
            bool isChanged = false;

            while (command[0].ToUpper() != "END")
            {
                isChanged = false;
                switch (command[0].ToUpper())
                {
                    case "ADD":
                        copiedList.Add(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "REMOVE":
                        copiedList.Remove(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "REMOVEAT":
                        copiedList.RemoveAt(int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "INSERT":
                        copiedList.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        isChanged = true;
                        break;
                    case "CONTAINS":
                        if (copiedList.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else if (!copiedList.Contains(int.Parse(command[1])))
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PRINTEVEN":
                        for (int i = 0; i < copiedList.Count; i++)
                        {
                            int currentInteger = copiedList[i];
                            if (currentInteger % 2 == 0)
                            {
                                Console.Write(currentInteger + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PRINTODD":
                        for (int i = 0; i < copiedList.Count; i++)
                        {
                            int currentInteger = copiedList[i];
                            if (currentInteger % 2 != 0)
                            {
                                Console.Write(currentInteger + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GETSUM":
                        int sumAll = 0;
                        for (int i = 0; i < copiedList.Count; i++)
                        {
                            int currentInteger = copiedList[i];
                            sumAll += currentInteger;
                        }
                        Console.WriteLine(sumAll);
                        break;
                    case "FILTER":
                        if (command[1] == "<")
                        {
                            List<int> results = new List<int>(copiedList.Where(n => n < int.Parse(command[2])));
                            Console.WriteLine(string.Join(' ', results));
                        }
                        else if (command[1] == ">")
                        {
                            List<int> results = new List<int>(copiedList.Where(n => n > int.Parse(command[2])));
                            Console.WriteLine(string.Join(' ', results));
                        }
                        else if (command[1] == ">=")
                        {
                            List<int> results = new List<int>(copiedList.Where(n => n >= int.Parse(command[2])));
                            Console.WriteLine(string.Join(' ', results));
                        }
                        else if (command[1] == "<=")
                        {
                            List<int> results = new List<int>(copiedList.Where(n => n <= int.Parse(command[2])));
                            Console.WriteLine(string.Join(' ', results));
                        }
                        break;
                }
                command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(' ', copiedList));
            }

        }
    }
}
