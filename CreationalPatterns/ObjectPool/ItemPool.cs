using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.CreationalPatterns.ObjectPool
{
    public class ObjectPool<T>
    {
        private IList<T> _items;

        public ObjectPool(int maxSize, Func<T> create)
        {
            _items = new List<T>();
            for(var i = 0; i < maxSize; i++)
            {
                _items.Add(create());
            }
        }

        public T Aquire()
        {
            lock(this)
            {
                var item = _items.FirstOrDefault();
                _items.Remove(item);
                return item;
            }
        }

        public void Return(T item)
        {
            lock (this)
            {
                _items.Add(item);
            }
        }
    }
}
