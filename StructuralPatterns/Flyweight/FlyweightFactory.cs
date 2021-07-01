using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Flyweight
{
    public class FlyweightFactory
    {
        private readonly Dictionary<string, CarFlyweight> _flyweights;

        public FlyweightFactory(params CarFlyweight[] flyweights)
        {
            _flyweights = flyweights.ToDictionary(x => GetKey(x));
        }

        private string GetKey(CarFlyweight item)
        {
            var values = item.GetType().GetProperties().OrderBy(x => x.Name).Select(x => x.GetValue(item));
            return string.Join("_", values);
        }

        public CarFlyweight GetFlyweight(CarFlyweight carFlyweight)
        {
            var key = GetKey(carFlyweight);

            if(_flyweights.TryGetValue(key, out var cache))
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight");
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Creating new flyweight");
                cache = carFlyweight;
                _flyweights[key] = cache;
            }
            return cache;
        }

        public void Show()
        {
            var count = _flyweights.Count;
            Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var flyweight in _flyweights)
            {
                Console.WriteLine(flyweight.Key);
            }
        }
    }
}
