using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Motorcycle : Vehicle
    {
        bool HasSidecar { get; set; }
        public Motorcycle(string make, string model, bool hasSidecar, int horsepower, FuelType fuelType, int topSpeed) 
            : base(make, model, new MotorcycleEngine(horsepower, fuelType, topSpeed))
        {
            HasSidecar = hasSidecar;
        }

        protected override void Accelerate()
        {
            string message = $"{Make} {Model} speed: ";
            double fuelMod = EngineType.FuelType switch
            {
                FuelType.Unleaded => 1.5D,
                FuelType.Leaded => 1.2D,
                FuelType.Diesel => 1.8D,
                _ => throw new InvalidOperationException($"Unexpected value: {EngineType.FuelType}")
            };
            for (double i = 0; i < 2; i += 0.1)
            {
                double newSpeed = ((EngineType.Horsepower * fuelMod) * Math.Exp(Math.Sqrt(i)) / 2) * (HasSidecar ? 0.8 : 1.0);

                if (newSpeed > EngineType.TopSpeed)
                {
                    Console.WriteLine($"{message}{EngineType.TopSpeed:F2}mph");
                }
                else
                {
                    Console.WriteLine($"{message}{newSpeed:F2}mph");
                }
            }
        }
    }
}
