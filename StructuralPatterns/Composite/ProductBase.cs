using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Composite
{
    public abstract class ProductBase
    {
        protected string Name { get; }
        protected int Price { get; }

        public ProductBase(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public abstract int CalculateTotalPrice();
    }
}
