using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Observer
{
    public abstract class Observer<T> : IObserver<T>
    {
        public IDisposable Subscription { get; set; }

        public void OnCompleted()
        {
            Console.WriteLine($"{Name}: Ubsubscribing");
            Subscription.Dispose();
        }
        public void OnError(Exception error)
        {
            Console.WriteLine($"{Name}: {error.GetType().Name} ({error.Message})");
        }
        public abstract void OnNext(T value);

        protected string Name => GetType().Name;

        protected void Reaction(T value)
        {
            Console.WriteLine($"{Name} reaguje na wartość {value}");
        }
    }
}
