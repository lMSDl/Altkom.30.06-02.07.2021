using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Observer
{
    public class Subject : IObservable<int>, IDisposable
    {
        private ICollection<IObserver<int>> _observers = new List<IObserver<int>>();
        private int index;

        public IDisposable Subscribe(IObserver<int> observer)
        {
            _observers.Add(observer);
            return new Unsubscriber(() => _observers?.Remove(observer));
        }

        public int Index
        {
            get => index;
            set
            {
                index = value;
                Task.Run(() => Notify());
            }
        }

        public void SomeImportantJob()
        {
            Console.WriteLine("I'm doint domething important..");
            Thread.Sleep(1000);

            Index = new Random().Next(-1, 10);

            Console.WriteLine("My state has just changed to: " + Index);
            //Notify();
        }

        private void Notify()
        {
            if (Index < 0)
                _observers.ToList().ForEach(x => x.OnError(new IndexOutOfRangeException(Index.ToString())));
            else
                _observers.ToList().ForEach(x => x.OnNext(Index));
        }

        public void Dispose()
        {
            var observers = _observers.ToList();
            _observers = null;

            observers.ForEach(x => x.OnCompleted());
        }
    }
}
