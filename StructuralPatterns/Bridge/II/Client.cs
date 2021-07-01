using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Bridge.II
{
    public class Client
    {
        public static void Execute()
        {
            var shape = new Circle();

            Console.WriteLine(shape);
            shape = new Circle() { Color = new RedColor()};

            Console.WriteLine(shape);
            shape = new Circle() { Color = new BlueColor() { Brightness = new Dark()} };

            Console.WriteLine(shape);

        }
    }
}
