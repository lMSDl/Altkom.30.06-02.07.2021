using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Mediator
{
    public interface IChatMediator
    {
        void Join(ChatMember member);
        void Quit(ChatMember member);

        void Send(string from, string message);
        void Send(string from, string to, string message);
    }
}
