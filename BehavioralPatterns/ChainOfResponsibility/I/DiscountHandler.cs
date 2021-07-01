using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.ChainOfResponsibility.I
{
    public class DiscountHandler : BaseHandler<DiscountHandler>, IDiscountHandler
    {
        public float MaxDiscount { get; }

        public float MinPrice { get; }

        public DiscountHandler(float maxDiscount, float minPrice, DiscountHandler next) : base(next)
        {
            MaxDiscount = maxDiscount;
            MinPrice = minPrice;
        }
        public DiscountHandler(float maxDiscount, float minPrice) : this(maxDiscount, minPrice, null)
        {
        }

        public virtual bool Discount(float value, float price)
        {
            if (value <= MaxDiscount && price >= MinPrice)
            {
                Console.WriteLine(Name);
                return true;
            }

            return Next?.Discount(value, price) ?? false;
        }
    }
}
