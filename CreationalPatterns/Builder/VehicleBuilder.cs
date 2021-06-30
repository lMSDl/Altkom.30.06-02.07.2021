using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.CreationalPatterns.Builder
{
    public class VehicleBuilder
    {
        private Vehicle _vehicle = new Vehicle();

        public void SetWheels(int value)
        {
            _vehicle.Wheels = value;
        }
        public void SetSeats(int value)
        {
            _vehicle.Seats = value;
        }
        public void SetDoors(int value)
        {
            _vehicle.Doors = value;
        }
        public void SetTrunkCapacity(int? value)
        {
            _vehicle.TrunkCapacity = value;

        }
        public void SetEnginePower(int? value)
        {
            _vehicle.EnginePower = value;
        }

        public Vehicle Build()
        {
            return _vehicle;
        }
    }
}
