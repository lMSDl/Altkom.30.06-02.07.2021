using System;
using WPCSharp.SOLID.L;

namespace WPCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            WPCSharp.CreationalPatterns.Builder.Client.Execute();

        }

        private static void LSP()
        {
            var a = 5;
            var b = 3;
            Console.Write($"{a} * {b} = ");

            Rectangle rectangle = new Square();

            FillRectangle(rectangle, a, b);
            PrintArea(rectangle);
        }

        static void FillRectangle(Rectangle rectangle, int a, int b)
        {
            rectangle.A = a;
            rectangle.B = b;
        }

        static void PrintArea(Rectangle rectangle)
        {
            Console.WriteLine(rectangle.Area);
        }
    }
}
