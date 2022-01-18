using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();

            while (command?.ToLower() != "end")
            {
                string[] commandArr = command.Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
                string companyName = commandArr[0];
                string id = commandArr[1];

                if (companyUsers.ContainsKey(companyName) == false)
                {
                    companyUsers.Add(companyName, new List<string>());
                    companyUsers[companyName].Add(id);
                }
                else
                {
                    if (companyUsers[companyName][0] == id) 
                    {
                        continue;
                        command = Console.ReadLine();
                    }
                    else
                    {
                        companyUsers[companyName].Add(id);
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var company in companyUsers.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{company.Key}");

                foreach (var users in company.Value)
                {
                    Console.WriteLine($"-- {users}");
                }
            }
        }
    }
}
