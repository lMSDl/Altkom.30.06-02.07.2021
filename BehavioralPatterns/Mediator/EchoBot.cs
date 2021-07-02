﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Mediator
{
    public class EchoBot : ChatMember
    {
        public EchoBot(string nick) : base(nick)
        {
        }

        public override void Receive(string from, string message, bool isPrivate)
        {
            if(isPrivate)
            {
                Chat.Send(Nick, from, message);
            }
            else
            {
                Chat.Send(Nick, message);
            }
        }
    }
}
