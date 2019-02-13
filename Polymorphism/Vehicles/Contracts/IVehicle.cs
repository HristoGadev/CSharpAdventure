using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Contracts
{
    public interface IVehicle
    {
        double FuelQuantity { get; }
        double FuelConsumptionPerKm { get; }
        double TankCapacity { get; }
        bool IsBusFulled { get; set; }
        void Refuel(double fuel);
        void Drive(double distance);
    }
}
