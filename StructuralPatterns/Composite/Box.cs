using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Composite
{
    public class Box : ProductBase
    {
        private List<ProductBase> _content;

        public Box(string name, int price)
            : base(name, price)
        {
            _content = new List<ProductBase>();
        }

        public void Add(ProductBase product)
        {
            _content.Add(product);
        }

        public void Remove(ProductBase product)
        {
            _content.Remove(product);
        }

        public override int CalculateTotalPrice()
        {
            int total = 0;

            Console.WriteLine($"{Name} contains the following products with prices:");

            foreach (var gift in _content)
            {
                total += gift.CalculateTotalPrice();
            }

            return total;
        }
    }
}
