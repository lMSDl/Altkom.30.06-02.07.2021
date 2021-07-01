using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Iterator
{
    public class Buffer<T> : IEnumerable<Tuple<T, T>>
    {
        private IEnumerable<T> _items;

        public Buffer(IEnumerable<T> items)
        {
            _items = items;
        }

        public IEnumerator<Tuple<T, T>> GetEnumerator()
        {
            return new BufferIterator<T>(_items.GetEnumerator());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
