using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Contracts;
using Vehicles.Models;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumptionPerKm;
        private double tankCapacity;
        private bool isBusFulled;

        protected Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
          
        }

        public double FuelQuantity
        {
            get => fuelQuantity;
            set
            {
                if (this.TankCapacity < value)
                {
                    tankCapacity = 0;
                }
                fuelQuantity = value;
            }
        }
        public double FuelConsumptionPerKm
        {
            get => fuelConsumptionPerKm;
            set => fuelConsumptionPerKm = value;
        }
        public double TankCapacity
        {
            get => tankCapacity;
            set => tankCapacity = value;
        }

        public bool IsBusFulled { get; set; }
        public void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (this.FuelQuantity + fuel > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {fuel} fuel in the tank");
            }
            if (this is Truck)
            {
                fuel *= 0.95;
            }
            this.FuelQuantity += fuel;
        }
        public virtual void Drive(double distance)
        {

            var neededFuel = distance * this.FuelConsumptionPerKm;
            if (this.FuelQuantity < neededFuel)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            this.FuelQuantity -= neededFuel;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
