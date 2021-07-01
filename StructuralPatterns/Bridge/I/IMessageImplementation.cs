using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Bridge
{
    public interface IMessageImplementation
    {
        IEnumerable<string> AdaptMessage(string message);
        void SendMessage(string message);
    }
}
