using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Engine
    {
        bool Running { get; set; } = false;
        int Horespower { get; set; }

       FuelType FuelType { get; set; }

        public Engine (int horsepower, FuelType fuelType)
        {
            Horespower = horsepower;
            FuelType = fuelType;
        }
    }
}
