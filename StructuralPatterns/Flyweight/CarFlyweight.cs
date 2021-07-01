using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Flyweight
{
    public class CarFlyweight
    {
        public string Company { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public void SomeOperation(Car uniqueState)
        {
            string s = JsonConvert.SerializeObject(this);
            string u = JsonConvert.SerializeObject(uniqueState);
            Console.WriteLine($"Flyweight: Displaying shared state:\n{s}\nand unique state:\n{u}");
        }
    }
}
