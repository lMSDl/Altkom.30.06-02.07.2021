using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.ChainOfResponsibility.II
{
    public abstract class Component
    {
        public Component Parent { get; set; }

        public void Click()
        {
            Click(false);
        }
        public virtual void Click(bool handled)
        {
            Parent?.Click(handled);
        }
    }
}
