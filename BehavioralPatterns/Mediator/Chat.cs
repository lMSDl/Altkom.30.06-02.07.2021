using System.Collections.Generic;
using System.Linq;

namespace WPCSharp.BehavioralPatterns.Mediator
{
    public class Chat : IChatMediator
    {
        private ICollection<ChatMember> _members = new List<ChatMember>();

        public void Join(ChatMember member)
        {
            _members.Add(member);
        }

        public void Quit(ChatMember member)
        {
            _members.Remove(member);
        }

        public void Send(string from, string message)
        {
            var sender = _members.Single(x => x.Nick == from);

            var query = _members.AsEnumerable();
            if (sender is EchoBot)
            {
                query = query.Where(x => !(x is EchoBot));
            }
            else
            {
                query = query.Where(x => x.Nick != from);
            }

            foreach (var member in query)
            {
                member.Receive(from, message, false);
            }
        }

        public void Send(string from, string to, string message)
        {
            _members.ToList().SingleOrDefault(x => x.Nick == to)?.Receive(from, message, true);
        }
    }
}
