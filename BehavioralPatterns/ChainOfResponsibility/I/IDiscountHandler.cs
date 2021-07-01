using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.ChainOfResponsibility.I
{
    public interface IDiscountHandler
    {
        float MaxDiscount { get; }
        float MinPrice { get; }
        bool Discount(float value, float price);
    }
}
