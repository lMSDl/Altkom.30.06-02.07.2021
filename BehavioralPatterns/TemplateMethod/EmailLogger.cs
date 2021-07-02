using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.TemplateMethod
{
    public class EmailLogger : Logger<IDisposable>
    {
        protected override void Store(IDisposable service, string message)
        {
            Console.WriteLine("Sending Email with Log Message : " + message);
        }

        protected override IDisposable GetService()
        {
            return null;
        }

        protected override void AfterGettingService()
        {
        }

        protected override void BeforeGettingService()
        {
        }
    }
}
