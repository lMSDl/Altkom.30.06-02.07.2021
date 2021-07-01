using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Composite
{
    public static class Client
    {
        public static void Execute()
        {
            var phone = new Product("Phone", 256);
            phone.CalculateTotalPrice();
            Console.WriteLine();

            var rootBox = new Box("RootBox", 0);

            var truckToy = new Product("TruckToy", 289);
            var plainToy = new Product("PlainToy", 587);

            rootBox.Add((ProductBase)truckToy.Clone());
            rootBox.Add((ProductBase)truckToy.Clone());
            rootBox.Add((ProductBase)plainToy.Clone());
            rootBox.Add((ProductBase)plainToy.Clone());
            rootBox.Add((ProductBase)plainToy.Clone());

            var childBox = new Box("ChildBox", 0);
            var soldierToy = new Product("SoldierToy", 200);
            childBox.Add((Product)soldierToy.Clone());
            childBox.Add((Product)soldierToy.Clone());
            childBox.Add((Product)soldierToy.Clone());

            rootBox.Add(childBox);

            var room = new Box("Room", 0);
            room.Add(rootBox);
            room.Add(phone);


            Console.WriteLine($"Total price of this composite present is: {room.CalculateTotalPrice()}");

            childBox.CalculateTotalPrice();
        }
    }
}
