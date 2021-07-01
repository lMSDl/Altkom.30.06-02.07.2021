using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Iterator
{
    public class Client
    {
        public static void Execute()
        {
            var list = new List<string>() { "a", "b", "c", "d", "e" };
            var buffer = new Buffer<string>(list.ToList());

            list.ToObservable()
                .Buffer(2, 1)
                .Where(x => x.Count == 2)
                .ForEachAsync(x => Console.WriteLine(x[0]+x[1])).Wait();

            Console.WriteLine();
            
            //var last = list.First();
            //for (int i = 1; i < list.Count; i++)
            //{
            //    var current = list[i];
            //    Console.WriteLine($"{last}{current}");
            //    last = current;
            //}

            using (var iterator = buffer.GetEnumerator())
            {

                while(iterator.MoveNext())
                {
                    Console.WriteLine($"{iterator.Current.Item1}{iterator.Current.Item2}");
                    list.Clear();
                }
            }
            Console.WriteLine();

            foreach (var item in buffer)
            {
                Console.WriteLine($"{item.Item1}{item.Item2}");
            }

        }
    }
}
