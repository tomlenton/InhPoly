using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Boat : Vehicle
    {
        bool IsInWater { get; set; }
        public Boat(string make, string model, bool isInWater, int horsepower, FuelType fuelType)
            : base(make, model, new BoatEngine(horsepower, fuelType))
        {
            IsInWater = isInWater;
        }

        protected override void Accelerate()
        {
            string message = $"{Make} {Model} speed: ";
            double fuelMod = EngineType.FuelType switch
            {
                FuelType.Unleaded => 1.5D,
                FuelType.Leaded => 1.2D,
                FuelType.Diesel => 1.8D,
                FuelType.BoatFuel => 4.0D,
                _ => throw new InvalidOperationException($"Unexpected value: {EngineType.FuelType}")
            };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{message}{((EngineType.Horsepower * fuelMod) * Math.Exp(Math.Sqrt(i)) / 2) * (IsInWater ? 2.0 : 0.0)}mph");
            }
        }
        public void GetIntoTheWater()
        {
            IsInWater = true;
        }
    }
}
