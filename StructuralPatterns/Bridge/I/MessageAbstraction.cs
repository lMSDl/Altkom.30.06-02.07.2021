using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Bridge
{
    public class MessageAbstraction
    {
        public IMessageImplementation Implementation { get; set; }

        public MessageAbstraction(IMessageImplementation implementation)
        {
            Implementation = implementation;
        }

        public void Send(string message)
        {
            var msgAdapted = Implementation.AdaptMessage(message);
            msgAdapted.ToList().ForEach(x => Implementation.SendMessage(x));
        }
    }
}
