using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Engine
    {
        internal bool Running { get; set; } = false;
        internal int Horsepower { get; set; }

        internal int TopSpeed {  get; set; }

        internal FuelType FuelType { get; set; }

        public Engine (int horsepower, FuelType fuelType, int topSpeed)
        {
            Horsepower = horsepower;
            FuelType = fuelType;
            TopSpeed = topSpeed;
        }

        public void Start()
        {
            Running = true;
        }
    }
}
