using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Observer
{
    public class ObserverA : Observer<int>
    {
        public override void OnNext(int value)
        {
            if (value % 2 == 0)
                Reaction(value);
            else
                Subscription.Dispose();
        }
    }
}
