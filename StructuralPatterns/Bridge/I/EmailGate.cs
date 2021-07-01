using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Bridge
{
    class EmailGate : IMessageImplementation
    {
        public IEnumerable<string> AdaptMessage(string message)
        {
            return new List<string>() { message };
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }
}
