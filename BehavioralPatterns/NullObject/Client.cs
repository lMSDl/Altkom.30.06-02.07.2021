using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.NullObject
{
    public class Client
    {
        public static IOutput Output { get; set; }
        public static void Execute()
        {
            while (true)
            {
                switch (Console.ReadKey().KeyChar)
                {
                    case 'c':
                        Output = new ConsoleOutput();
                        break;
                    case 'd':
                        Output = new DebugOutput();
                        break;
                    default:
                        Output = new NullOutput();
                        break;
                }

                Console.WriteLine();
                //if(Output != null)
                    Output.Show(Console.ReadLine());
                //Output?.Show(Console.ReadLine());
            }
        }
    }
}