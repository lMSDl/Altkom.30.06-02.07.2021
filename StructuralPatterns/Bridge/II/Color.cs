using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Bridge.II
{
    public abstract class Color
    {
        public Brightness Brightness { get; set; }

        public abstract string ColorValue { get; }

        public override string ToString()
        {
            return Brightness == null ? ColorValue : $"{Brightness} {ColorValue}";
        }
    }
}
