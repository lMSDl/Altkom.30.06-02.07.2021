using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Adapter.I
{
    public class Client
    {
        public static void Execute()
        {
            var circle = new Circle() { Radius = 5 };
            var square = new Square() { Width = 5 };

            Console.WriteLine(Check(circle));
            Console.WriteLine(Check(new SquareToCircleAdapter(square)));
        }

        public static bool Check(ICircle circle)
        {
            return circle.Radius <= 5;
        }
    }
}
