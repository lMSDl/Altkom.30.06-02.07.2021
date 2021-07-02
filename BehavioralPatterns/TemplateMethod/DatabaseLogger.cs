using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.TemplateMethod
{
    public class DatabaseLogger : Logger<DatabaseService>
    {
        protected override string PrepareMessage(string @string)
        {
            Console.WriteLine("Serializing message");
            return @string.ToString();
        }

        protected override void Store(DatabaseService service, string message)
        {
            service.Insert(message);
        }

        protected override DatabaseService GetService()
        {
            Console.WriteLine("Connecting to Database.");
            return new DatabaseService();
        }

        protected override void AfterGettingService()
        {
        }

        protected override void BeforeGettingService()
        {
        }
    }
}
