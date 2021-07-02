namespace WPCSharp.BehavioralPatterns.Mediator
{
    public abstract class ChatMember
    {
        private IChatMediator chat;

        public string Nick { get; }
        public IChatMediator Chat
        {
            get => chat;
            set
            {
                chat?.Quit(this);
                chat = value;
                chat?.Join(this);
            }
        }

        protected ChatMember(string nick)
        {
            Nick = nick;
        }

        public abstract void Receive(string from, string message, bool isPrivate);

        public void Send(string to, string message)
        {
            Chat.Send(Nick, to, message);
        }

        public void Send(string message)
        {
            Chat.Send(Nick, message);
        }
    }
}
