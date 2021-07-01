using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Bridge.II
{
    public abstract class Brightness
    {
        public abstract string Value { get; }

        public override string ToString()
        {
            return Value;
        }
    }
}
