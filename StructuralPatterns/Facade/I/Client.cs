using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Facade.I
{
    public class Client
    {
        public static void Execute()
        {
            var item = new Person { Name = "Ewa Ewowska", Age = 32 };

            var json = JsonConvertFacade.Serialize(item);

            Console.WriteLine(json);
        }
    }
}
