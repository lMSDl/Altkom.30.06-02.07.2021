using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Strategy
{
    public class Calculator
    {
        public ICalcStrategy Strategy { private get; set; }

        public float Execute(float val1, float val2)
        {
            return Strategy.Calculate(val1, val2);
        }
    }
}
