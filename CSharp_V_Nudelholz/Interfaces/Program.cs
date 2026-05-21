using System;
using Interfaces.Library;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicles = new()
            {
                new Car(name:"VW"),
                new Bicycle(name:"Marin, gravel"),
                new Car(name:"Audi"),
                new Car(name:"Tesla"),
            };

            foreach (var vehicle in vehicles)
            {
                vehicle.Start();
                if (vehicle is IFuel refuel)
                {
                    refuel.Refuel();
                }
            }
        }
    }
}