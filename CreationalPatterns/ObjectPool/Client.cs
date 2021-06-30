using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPCSharp.CreationalPatterns.ObjectPool
{
    public class Client
    {
        public static void Execute()
        {
            var pool = new ObjectPool<Item>(1000, () => new Item());
            //var counter = 0;
            while (true)
            {
                //if (counter > 1000)
                //{
                //    Thread.Sleep(1);
                //    continue;
                //}
                //var item = new Item() { IsVisible = true };
                //Task.Delay(1000).ContinueWith(x => { item.IsVisible = false; counter--; });
                //counter++;
                var item = pool.Aquire();
                if(item == null)
                {
                    Thread.Sleep(1);
                    continue;
                }
                Task.Delay(1000).ContinueWith(x => { item.IsVisible = false; pool.Return(item); });
            }
        }
    }
}
