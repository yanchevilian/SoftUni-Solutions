using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Authentication.ExtendedProtection;

namespace _3._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> firstNumberCollection = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToList();

            //List<int> secondNumberCollection = Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //    .ToList();


            //List<int> lists = new List<int>();

            //for (int i = 0; i < Math.Min(firstNumberCollection.Count, secondNumberCollection.Count); i++)
            //{
            //    lists.Add(firstNumberCollection[i]);
            //    lists.Add(secondNumberCollection[i]);
            //}

            //for (int i = Math.Min(firstNumberCollection.Count, secondNumberCollection.Count); i < Math.Max(firstNumberCollection.Count, secondNumberCollection.Count); i++)
            //{
            //    if (i >= firstNumberCollection.Count)
            //    {
            //        lists.Add(secondNumberCollection[i]);
            //    }
            //    else
            //    {
            //        lists.Add(firstNumberCollection[i]);
            //    }
            //}
            //Console.WriteLine(string.Join(" ", lists));

            List<int> firstNumberCollection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondNumberCollection = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> resultNums = new List<int>();

            for (int i = 0; i < Math.Min(firstNumberCollection.Count, secondNumberCollection.Count); i++)
            {
                resultNums.Add(firstNumberCollection[i]);
                resultNums.Add(secondNumberCollection[i]);
            }

            if (firstNumberCollection.Count > secondNumberCollection.Count)
            {
                resultNums.AddRange(GetRemainingElement(firstNumberCollection, secondNumberCollection));
            }
            else if (secondNumberCollection.Count > firstNumberCollection.Count)
            {
                resultNums.AddRange(GetRemainingElement(secondNumberCollection, firstNumberCollection));
            }
            Console.WriteLine(string.Join(" ", resultNums));
        }

        private static List<int> GetRemainingElement(List<int> longerList, List<int> shorterList)
        {
            List<int> nums = new List<int>();

            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                nums.Add(longerList[i]);
            }
            return nums;
        }
    }
}