using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.CreationalPatterns.Builder
{
    public class VehicleBuilderFacade : VehicleBuilderBase
    {
        public VehicleBuilderFacade()
        {
        }

        protected VehicleBuilderFacade(Vehicle vehicle) : base(vehicle)
        {
        }

        public VehicleBuilder Components => new VehicleBuilder(_vehicle);
        public VehicleInfoBuilder Info => new VehicleInfoBuilder(_vehicle);
    }
}
