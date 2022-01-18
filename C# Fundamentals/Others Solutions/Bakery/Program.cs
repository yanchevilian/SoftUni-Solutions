using System;

namespace _1._Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfBiscuitsPerDay = double.Parse(Console.ReadLine());
            double countOfWorkers = double.Parse(Console.ReadLine());
            double amountOfBiscuitsFromOtherCompany = double.Parse(Console.ReadLine());

            double sum = 0.0d;
            for (int dayCounter = 0; dayCounter < 30; dayCounter++)
            {
                if (dayCounter % 3 == 0)
                {
                    double currentProduction = (countOfWorkers * (amountOfBiscuitsPerDay * 0.75));
                    currentProduction = Math.Floor(currentProduction);
                    sum += currentProduction;
                }
                else
                {
                    sum += amountOfBiscuitsPerDay * countOfWorkers;
                }
            }
            Console.WriteLine($"You have produced {sum} biscuits for the past month.");

            double diff = sum - amountOfBiscuitsFromOtherCompany;
            double diffInPercents = (diff / amountOfBiscuitsFromOtherCompany) * 100;

            if (amountOfBiscuitsFromOtherCompany == sum)
            {
                return;
            }
            else if (sum > amountOfBiscuitsFromOtherCompany)
            {
                Console.WriteLine($"You produce {diffInPercents:F2} percent more biscuits.");
            }
            else if (amountOfBiscuitsFromOtherCompany > sum)
            {
                Console.WriteLine($"You produce {Math.Abs(diffInPercents):F2} percent less biscuits.");
            }
        }
    }
}
