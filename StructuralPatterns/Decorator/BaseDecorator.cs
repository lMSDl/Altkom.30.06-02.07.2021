using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Decorator
{
    public abstract class BaseDecorator : INotification
    {
        private readonly INotification _notification;

        protected BaseDecorator(INotification notification)
        {
            _notification = notification;
        }

        public void Send(string message)
        {
            _notification.Send(message);
            SendExtra(message);
        }

        protected abstract void SendExtra(string message);
    }
}
