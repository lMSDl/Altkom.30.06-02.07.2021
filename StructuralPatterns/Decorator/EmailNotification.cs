using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Decorator
{
    public class EmailNotification : BaseDecorator
    {
        public EmailNotification(INotification notification) : base(notification)
        {
        }

        protected override void SendExtra(string message)
        {
            Console.WriteLine("Email notification has been send: " + message);
        }
    }
}
