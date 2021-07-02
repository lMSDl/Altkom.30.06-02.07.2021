using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Mediator
{
    public class User : ChatMember
    {
        public User(string nick) : base(nick)
        {
        }

        public override void Receive(string from, string message, bool isPrivate)
        {
            if(isPrivate)
                Console.WriteLine($"{from} to me: {message}");
            else
                Console.WriteLine($"{from}: {message}");
        }


    }
}
