using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Mediator
{
    public class Client
    {
        public static void Execute()
        {
            var chat = new Chat();

            ChatMember user = new User("Paweł");
            ChatMember bot1 = new EchoBot("Paul");
            ChatMember bot2 = new EchoBot("Ringo");

            user.Chat = chat;
            bot1.Chat = chat;
            bot2.Chat = chat;

            while(true)
            {
                var to = Console.ReadLine();
                var message = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(to))
                {
                    user.Send(message);
                }
                else
                {
                    user.Send(to, message);
                }
            }
        }
    }

}
