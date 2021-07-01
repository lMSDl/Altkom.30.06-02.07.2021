using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Composite
{
    public class Product : ProductBase, ICloneable
    {
        public Product(string name, int price)
            : base(name, price)
        {
        }

        public override int CalculateTotalPrice()
        {
            Console.WriteLine($"{Name} with the price {Price}");

            return Price;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
