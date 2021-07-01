using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.CreationalPatterns.Builder
{
    public class VehicleInfoBuilder : VehicleBuilderFacade
    {
        public VehicleInfoBuilder()
        {
        }

        public VehicleInfoBuilder(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleInfoBuilder SetModel(string value)
        {
            _vehicle.Model = value;
            return this;
        }
        public VehicleInfoBuilder SetManufacturer(string value)
        {
            _vehicle.Manufacturer = value;
            return this;
        }
    }
}
