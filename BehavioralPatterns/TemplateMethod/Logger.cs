using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.TemplateMethod
{
    public abstract class Logger<T> where T : IDisposable
    {
        public void Log(string @string)
        {
            BeforeGettingService();
            using (T service = GetService())
            {
                AfterGettingService();
                string message = PrepareMessage(@string);
                Store(service, message);
            }
        }

        protected abstract void AfterGettingService();
        protected abstract void BeforeGettingService();
        protected abstract void Store(T service, string message);

        protected virtual string PrepareMessage(string @string)
        {
            return @string;
        }

        protected abstract T GetService();
    }
}
