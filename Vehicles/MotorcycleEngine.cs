using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class MotorcycleEngine : Engine
    {
        public MotorcycleEngine(int horsepower, FuelType fuelType, int topSpeed) 
            : base(horsepower, fuelType, topSpeed)
        {

        }
    }
}
