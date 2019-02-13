using System;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private double distanceTraveled;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }

        public double FuelConsuption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public double DistanceTraveled
        {
            get { return distanceTraveled; }
            set { distanceTraveled = value; }
        }

        public Car()
        {
            distanceTraveled = 0;
        }

        public void Drive(double distance)
        {
            if (distance <= fuelAmount / fuelConsumption)
            {
                distanceTraveled += distance;
                fuelAmount -= fuelConsumption * distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{model} {fuelAmount:F2} {distanceTraveled}";
        }
    }
}