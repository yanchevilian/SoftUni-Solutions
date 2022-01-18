using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            List<Truck> allTrucks = new List<Truck>();
            List<Car> allCars = new List<Car>();  
            List<CollectionOfTruckAndCars> Catalogue = new List<CollectionOfTruckAndCars>();
            while (input.ToLower() != "end")
            {
                string[] inputArr = input.Split("/", StringSplitOptions.RemoveEmptyEntries);
                //{ type}/{ brand}/{ model}/{ horse power / weight}
                string type = inputArr[0];
                string brand = inputArr[1];
                string model = inputArr[2];
                if (type.ToLower() == "truck")
                {
                    string weight = inputArr[3];
                    allTrucks.Add(new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    });
                }
                else if (type.ToLower() == "car")
                {
                    string horsePower = inputArr[3];
                    allCars.Add(new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePower
                    });
                }
                input = Console.ReadLine();
            }
            Catalogue.Add(new CollectionOfTruckAndCars
            {
                AllCars = allCars,
                AllTrucks = allTrucks
            });
            Console.WriteLine("Cars:");
            foreach (Car car in allCars.OrderBy(c => c.Brand).ToList())
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (Truck truck in allTrucks.OrderBy(t => t.Brand).ToList())
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }
    class CollectionOfTruckAndCars
    {
        public List<Truck> AllTrucks { get; set; }
        public List<Car> AllCars { get; set; }
    }
}
