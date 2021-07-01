using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Proxy
{
    public class Client
    {
        public static void Execute()
        {
            IDatabase database = new DatabaseProxy(new Database());

            for (var i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }

            Console.ReadKey();

            for (var i = 1; i < 16; i++)
            {
                Thread.Sleep(100);
                _ = database.RequestAsync(i);
            }
            Console.ReadKey();
        }
    }
}

