using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.ChainOfResponsibility.II
{
    public class Frame : Container
    {

        public override void Click(bool handled)
        {
            Console.WriteLine("Frame flashing");
            base.Click(handled);
        }
    }
}
