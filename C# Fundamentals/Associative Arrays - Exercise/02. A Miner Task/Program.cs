using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string command = Console.ReadLine();
            int counter = 0;
            string lastResource = "";

            while (command?.ToLower() != "stop")
            {
                if (!resources.ContainsKey(command))
                {
                    if (counter % 2 == 0)
                    {
                        resources.Add(command, 0);
                    }
                    else
                    {
                        int quantity = int.Parse(command);
                        resources[lastResource] += quantity;
                    }
                }
                lastResource = command;
                counter++;
                command = Console.ReadLine();
            }
            foreach (var resource in resources)
            {
                Console.WriteLine("{0} -> {1}", resource.Key,resource.Value);
            }
        }
    }
}