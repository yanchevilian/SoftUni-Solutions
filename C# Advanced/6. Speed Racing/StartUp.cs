using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _6._Speed_Racing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            var allCars = new Car[numberOfCars];
            
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                double fuelAmount = double.Parse(tokens[1]);
                double fuelConsumptionFor1Km = double.Parse(tokens[2]);
                Car car = new Car(model, fuelAmount, fuelConsumptionFor1Km);

                allCars[i] = car;
                
            }
            
            while (true)
            {
                string command = Console.ReadLine();
                if (command.ToLower() == "end")
                {
                    break;
                }

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = tokens[1];
                double amountOfKm = double.Parse(tokens[2]);

                allCars.Where(x => x.Model == carModel).ToList().ForEach(c => c.Drive(amountOfKm));
            }

            foreach (Car car in allCars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }

        }
    }
}
