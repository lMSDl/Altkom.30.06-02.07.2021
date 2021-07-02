using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.TemplateMethod
{
    public class FileLogger : Logger<FileService>
    {
        protected override string PrepareMessage(string @string)
        {
            Console.WriteLine("Serializing message");
            return @string.ToString();
        }

        protected override void Store(FileService service, string message)
        {
            service.Write(message);
        }

        protected override FileService GetService()
        {
            Console.WriteLine("Opening File.");
            return new FileService();
        }

        protected override void AfterGettingService()
        {
        }

        protected override void BeforeGettingService()
        {
        }
    }
}
