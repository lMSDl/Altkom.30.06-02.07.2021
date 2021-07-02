﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Strategy
{
    public class Client
    {
        public static void Execute()
        {
            var calculator = new Calculator();

            while (true)
            {
                var line = Console.ReadLine();

                var split = line.Split(' ');
                if (split.Length < 3)
                    continue;

                calculator.Strategy = GetCalcStrategy(split[1]);
                var func = GetFunc(split[1]);

                if (float.TryParse(split[0], out float val1) && float.TryParse(split[2], out float val2))
                {
                    var result = calculator.Execute(val1, val2);
                    Console.WriteLine(result);
                    Console.WriteLine(func(val1, val2));
                }
            }
        }

        private static ICalcStrategy GetCalcStrategy(string arg)
        {
            switch (arg)
            {
                case "*":
                    return new MultiplyStrategy();
                case "/":
                    return new DivideStrategy();
                case "+":
                    return new PlusStrategy();
                case "-":
                    return new MinusStrategy();
                default:
                    return null;
            }
        }

        private static Func<float, float, float> GetFunc(string arg)
        {
            switch (arg)
            {
                case "*":
                    return (a, b) => a * b;
                case "/":
                    return (a, b) => a / b;
                case "+":
                    return (a, b) => a + b;
                case "-":
                    return (a, b) => a - b;
                default:
                    return null;
            }
        }
    }
}
