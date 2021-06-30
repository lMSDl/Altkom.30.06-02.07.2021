using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.CreationalPatterns.Builder
{
    public class Vehicle
    {
        //public Vehicle(int wheels, int seats)
        //{
        //    Wheels = wheels;
        //    Seats = seats;
        //}

        //public Vehicle(int wheels, int seats, int doors) : this(wheels, seats)
        //{
        //    Doors = doors;
        //}

        //public Vehicle(int wheels, int seats, int doors, int trunkCapacity) : this(wheels, seats, doors)
        //{
        //    TrunkCapacity = trunkCapacity;
        //}
        //public Vehicle(int wheels, int seats, int doors, int trunkCapacity, int enginePower) : this(wheels, seats, doors, trunkCapacity)
        //{
        //    EnginePower = enginePower;
        //}

        public Vehicle()
        {
        }

        public int Wheels { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }
        public int? TrunkCapacity { get; set; }
        public int? EnginePower { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
