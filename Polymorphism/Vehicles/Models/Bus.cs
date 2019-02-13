using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private static double increasedConsumption = 1.4;
        public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity)
        {
        }
        public override void Drive(double distance)
        {
            var currentFuelConsumption = this.FuelConsumptionPerKm;
            if (!IsBusFulled)
            {
                currentFuelConsumption += increasedConsumption;
            }

            var neededFuel = distance * currentFuelConsumption;
            if (this.FuelQuantity < neededFuel)
            {
                throw new ArgumentException($"{this.GetType().Name} needs refueling");
            }
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            this.FuelQuantity -= neededFuel;

        }
    }
}
