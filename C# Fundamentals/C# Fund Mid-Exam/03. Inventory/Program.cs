using System;
using System.Collections.Generic;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> collectingItems = new List<string>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));
            List<string> commandArr = new List<string>();
            while (true)
            {
                commandArr = new List<string>(Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries));
                string command = commandArr[0].ToLower();
                if (command.ToLower() == "craft!")
                {
                    break;
                }
                string item = commandArr[1];
                int index = 0;
                if (collectingItems.Contains(item))
                {
                    index = collectingItems.IndexOf(item);
                }
                switch (command)
                {
                    case "collect":
                        string collectItem = commandArr[1];
                        if (collectingItems.Contains(collectItem))
                        {
                            continue;
                        }
                        else if (0 <= index && index < collectingItems.Count)
                        {
                            collectingItems.Add(collectItem);
                        }
                        break;
                    case "drop":
                        string dropItem = commandArr[1];
                        if (collectingItems.Contains(dropItem) && (0 <= index && index < collectingItems.Count))
                        {
                            collectingItems.Remove(dropItem);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "combine items":
                        string[] items = commandArr[1].Split(":", StringSplitOptions.RemoveEmptyEntries);
                        string oldItem = items[0];
                        string newItem = items[1];
                        int currentIndex = collectingItems.IndexOf(oldItem);
                        if (collectingItems.Contains(oldItem) && (currentIndex >= 0 && currentIndex < collectingItems.Count))
                        {
                            collectingItems.Insert(currentIndex + 1, newItem);
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "renew":
                        string renewItem = commandArr[1];
                        if (collectingItems.Contains(renewItem) && (0 <= index && index < collectingItems.Count)) 
                        {
                            collectingItems.Remove(renewItem);
                            collectingItems.Add(renewItem);
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", collectingItems));
        }
    }
}
