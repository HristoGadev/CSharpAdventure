using System;
using System.Collections.Generic;
using System.Text;
using Vehicles.Contracts;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class Engine
    {
        public void Run()
        {
            var carArgs = Console.ReadLine().Split();
            var car = FillCar(carArgs);

            var truckArgs = Console.ReadLine().Split();
            var truck = FillTruck(truckArgs);

            var busArgs = Console.ReadLine().Split();
            var bus = FillBus(busArgs);

            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                try
                {
                    var input = Console.ReadLine().Split();
                    var command = input[0];
                    var vehicleType = input[1];
                    var value = double.Parse(input[2]);

                    if (command == "Refuel")
                    {
                        var fuel = value;
                        if (vehicleType == "Car")
                        {
                            car.Refuel(fuel);
                        }
                        else if (vehicleType == "Truck")
                        {
                            truck.Refuel(fuel);
                        }
                        else if (vehicleType == "Bus")
                        {
                            bus.Refuel(fuel);
                        }

                    }
                    else if (command == "Drive")
                    {
                        var distance = value;

                        if (vehicleType == "Car")
                        {
                            car.Drive(distance);
                        }
                        else if (vehicleType == "Truck")
                        {
                            truck.Drive(distance);
                        }
                        else if (vehicleType == "Bus")
                        {
                            bus.IsBusFulled = false;
                            bus.Drive(distance);
                        }
                    }
                    else if (command == "DriveEmpty")
                    {
                        bus.IsBusFulled = true;
                        bus.Drive(value);
                    }

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private IVehicle FillBus(string[] busArgs)
        {
            var busFuelQuantity = double.Parse(busArgs[1]);
            var busFuelConsumption = double.Parse(busArgs[2]);
            var busTankCapacity = double.Parse(busArgs[3]);
            IVehicle bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);
            return bus;
        }

        private IVehicle FillTruck(string[] truckArgs)
        {
            var truckFuelQuantity = double.Parse(truckArgs[1]);
            var truckFuelConsumption = double.Parse(truckArgs[2]);
            var truckTankCapacity = double.Parse(truckArgs[3]);
            IVehicle truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);
            return truck;
        }

        private IVehicle FillCar(string[] carArgs)
        {
            var carFuelQuantity = double.Parse(carArgs[1]);
            var carFuelConsumption = double.Parse(carArgs[2]);
            var carTankCapacity = double.Parse(carArgs[3]);
            IVehicle car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
            return car;
        }
    }
}
