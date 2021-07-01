using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Bridge
{
    public class Client
    {
        public static void Execute()
        {
            Console.WriteLine("Send short SMS");
            MessageAbstraction message = new MessageAbstraction(new SmsGate());
            message.Send(Console.ReadLine());


            Console.WriteLine("Send Email");
            //message = new MessageAbstraction(new EmailGate());
            message.Implementation = new EmailGate();
            message.Send(Console.ReadLine());
        }
    }
}
