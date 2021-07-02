using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Strategy
{
    public class DivideStrategy : ICalcStrategy
    {
        public float Calculate(float val1, float val2)
        {
            return val1 / val2;
        }
    }
}
