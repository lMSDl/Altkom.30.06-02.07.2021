using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Flyweight
{
    public class Car
    {
        public string Owner { get; set; }
        public string Number { get; set; }
        public string Company { get => CarFlyweight.Company; set => CarFlyweight.Company = value; }
        public string Model { get => CarFlyweight.Model; set => CarFlyweight.Model = value; }
        public string Color { get => CarFlyweight.Color; set => CarFlyweight.Color = value; }

        [JsonIgnore]
        public CarFlyweight CarFlyweight { get; set; } = new CarFlyweight();
    }
}
