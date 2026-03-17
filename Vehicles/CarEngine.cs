using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Vehicles
{
    public  class CarEngine : Engine
    {
        public CarEngine(int horsepower, FuelType fuelType, int topSpeed) 
            : base(horsepower, fuelType, topSpeed)
        {

        }
    }
}
