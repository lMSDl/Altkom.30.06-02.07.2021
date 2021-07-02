using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Strategy
{
    public interface ICalcStrategy
    {
        float Calculate(float val1, float val2);
    }
}
