using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.CreationalPatterns.Builder
{
    public abstract class VehicleBuilderBase
    {
        protected Vehicle _vehicle;

        public VehicleBuilderBase() : this(new Vehicle())
        {
        }

        public VehicleBuilderBase(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public Vehicle Build()
        {
            return (Vehicle)_vehicle.Clone();
        }
    }
}
