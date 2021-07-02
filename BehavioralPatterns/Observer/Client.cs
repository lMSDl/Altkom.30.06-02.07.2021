using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Observer
{
    public class Client
    {
        public static void Execute()
        {
            var a = new ObserverA();
            var b = new ObserverB();

            using (var subject = new Subject())
            {
                a.Subscription = subject.Subscribe(a);
                b.Subscription = subject.Subscribe(b);

                subject.SomeImportantJob();
                subject.SomeImportantJob();
                //a.Subscription.Dispose();
                subject.SomeImportantJob();
                subject.SomeImportantJob();
                a.Subscription = subject.Subscribe(a);
                subject.SomeImportantJob();
            }

            Console.ReadLine();
        }

        }
}
