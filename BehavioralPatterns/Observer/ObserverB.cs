using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Observer
{
    public class ObserverB : Observer<int>
    {
        public override void OnNext(int value)
        {
            if (value > 8 || value < 3)
                Reaction(value);
            else
            {
                Thread.Sleep(5000);
                Reaction(value);
            }
        }
    }
}
