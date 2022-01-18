using System;

namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int battles = 0;
            bool isWinner = true;
            int wonGames = 0;

            while (command?.ToLower() != "end of battle")
            {
                int distance = int.Parse(command);

                if (initialEnergy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonGames} won battles and {initialEnergy} energy");
                    isWinner = false;
                    break;
                }
                battles++;

                initialEnergy -= distance;
                wonGames++;
                if (battles % 3 == 0)
                {
                    initialEnergy += battles;
                }

                command = Console.ReadLine();
            }
            if (isWinner)
            {
                Console.WriteLine($"Won battles: {wonGames}. Energy left: {initialEnergy}");
            }
        }
    }
}
