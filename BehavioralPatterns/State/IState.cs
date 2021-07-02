using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.State
{
    public interface IState
    {
        void SmallCoffee();
        void LargeCoffee();
    }
}
