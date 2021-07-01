using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Decorator
{
    public class SmsNotification : BaseDecorator
    {
        public SmsNotification(INotification notification) : base(notification)
        {
        }

        protected override void SendExtra(string message)
        {
            Console.WriteLine("Sms notification has been send: " + message);
        }
    }
}
