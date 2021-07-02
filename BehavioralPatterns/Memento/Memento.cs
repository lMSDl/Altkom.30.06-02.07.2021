using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Memento
{
    public class Memento<T>
    {
        public T State { get; }
        public DateTime DateTime { get; }

        public Memento(T state)
        {
            State = state;
            DateTime = DateTime.Now;
        }

        public void Restore(T originator)
        {
            originator.GetType().GetProperties().Where(x => x.CanWrite).Where(x => x.CanRead)
                .ToList().ForEach(x => x.SetValue(originator, x.GetValue(State)));
        }
    }
}
