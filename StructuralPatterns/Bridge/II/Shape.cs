using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Bridge.II
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public override string ToString()
        {
            return Color != null ? $"{Color} {GetType().Name}" : $"{GetType().Name}";
        }
    }
}
