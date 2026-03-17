using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        int Speed { get; set; }

        Engine EngineType { get; set; }

        //public Vehicle(string make, string model, int speed)
        //{
        //    Make = make;
        //    Model = model;
        //    Speed = speed;
        //}
    }
}
