using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.CreationalPatterns.Builder
{
    public class Client
    {
        public static void Execute()
        {
            //var vehicleBuilder = new VehicleBuilder();
            //vehicleBuilder.SetDoors(2);
            //vehicleBuilder.SetSeats(2);
            //vehicleBuilder.SetWheels(4);
            //vehicleBuilder.SetEnginePower(100);
            //vehicleBuilder.SetTrunkCapacity(500);

            //var vehicle = vehicleBuilder.Build();

            var builder = new VehicleBuilder()
            .SetDoors(2)
            .SetSeats(2)
            .SetWheels(4)
            .SetEnginePower(100)
            .SetTrunkCapacity(500);

            Console.WriteLine(builder.Build());

            builder.SetWheels(3);
            Console.WriteLine(builder.Build());
        }
    }
}
