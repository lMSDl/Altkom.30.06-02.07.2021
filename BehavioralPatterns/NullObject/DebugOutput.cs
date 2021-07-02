using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.NullObject
{
    public class DebugOutput : IOutput
    {
        public void Show(string message)
        {
            Debug.WriteLine(message);
        }
    }
}
