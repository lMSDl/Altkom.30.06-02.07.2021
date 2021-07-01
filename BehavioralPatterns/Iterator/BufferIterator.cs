using System;
using System.Collections;
using System.Collections.Generic;

namespace WPCSharp.BehavioralPatterns.Iterator
{
    class BufferIterator<T> : IEnumerator<Tuple<T, T>>
    {
        private IEnumerator<T> _enumerator;

        public BufferIterator(IEnumerator<T> enumerator)
        {
            _enumerator = enumerator;
            Reset();
        }

        private T Last { get; set; }
        public Tuple<T, T> Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            _enumerator.Dispose();
            _enumerator = null;
            Last = default;
            Current = null;
        }

        public bool MoveNext()
        {
            if(_enumerator.MoveNext())
            {
                Current = new Tuple<T, T>(Last, _enumerator.Current);
                Last = _enumerator.Current;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _enumerator.Reset();
            if(_enumerator.MoveNext())
            {
                Last = _enumerator.Current;
            }
            Current = null;
        }
    }
}
