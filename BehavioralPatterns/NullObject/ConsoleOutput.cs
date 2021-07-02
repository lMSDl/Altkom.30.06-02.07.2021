using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.NullObject
{
    public class ConsoleOutput : IOutput
    {
        public void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}
