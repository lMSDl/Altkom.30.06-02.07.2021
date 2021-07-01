﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Bridge
{
    public class SmsGate : IMessageImplementation
    {
        public const int MaxLength = 10;

        public void SendMessage(string message)
        {
            Console.WriteLine("SMS: " + message);
        }

        IEnumerable<string> IMessageImplementation.AdaptMessage(string message)
        {
            return Enumerable.Range(0, (int)Math.Ceiling((float)message.Length / MaxLength))
                   .Select(x => message.Substring(x * MaxLength, Math.Min(MaxLength, message.Length - x * MaxLength)));
        }
    }
}
