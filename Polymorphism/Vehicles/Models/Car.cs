using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private static double increasedFuelConsump = 0.9;
        public Car(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionPerKm,tankCapacity)
        {
            this.FuelConsumptionPerKm += increasedFuelConsump;
        }
    }
}
