using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>>registeredUsers = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] inputCmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = inputCmd[0];
                string user = inputCmd[1];

                switch (command.ToLower())
                {
                    case "register":
                        string licensePlateNumber = inputCmd[2];
                        if (registeredUsers.ContainsKey(user) == false)
                        {
                            registeredUsers.Add(user, new List<string> { licensePlateNumber });
                            Console.WriteLine($"{user} registered {licensePlateNumber} successfully");
                        }
                        else
                        {
                            if (registeredUsers[user][0] == licensePlateNumber)
                            {
                                Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                                continue;
                            }
                        }
                        break;
                    case "unregister":
                        if (registeredUsers.ContainsKey(user) == false)
                        {
                            Console.WriteLine($"ERROR: user {user} not found");
                            continue;
                        }
                        else
                        {
                            registeredUsers.Remove(user);
                            Console.WriteLine($"{user} unregistered successfully");
                        }
                        break;
                }
            }
            foreach (var users in registeredUsers)
            {
                Console.WriteLine($"{users.Key} => {users.Value[0]}");
            }
        }
    }
}
