using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Schema;

namespace _6._Speed_Racing
{
    public class Car
    {
        private string _model;
        private double _fuelAmount;
        private double _fuelConsumptionPerKilometer;
        private double _travelledDistance;
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }
        
        public string Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        public double FuelAmount
        {
            get { return this._fuelAmount; }
            set { this._fuelAmount = value; }
        }

        public double FuelConsumptionPerKilometer
        {
            get { return this._fuelConsumptionPerKilometer; }
            set { this._fuelConsumptionPerKilometer = value; }
        }

        public double TravelledDistance
        {
            get { return this._travelledDistance; }
            set { this._travelledDistance = value; }
        }

        public void Drive(double amountOfKilometers)
        {
            double litresForTheTrip = FuelConsumptionPerKilometer * amountOfKilometers;
            if (litresForTheTrip < FuelAmount)
            {
                FuelAmount -= litresForTheTrip;
                TravelledDistance += amountOfKilometers;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
