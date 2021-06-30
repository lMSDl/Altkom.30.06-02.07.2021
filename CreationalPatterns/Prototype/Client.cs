using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.CreationalPatterns.Prototype
{
    public class Client
    {
        public static void Execute()
        {
            var p1 = new Person
            {
                Age = 23,
                Name = "Adam Adamski",
                IdInfo = new IdInfo(),
                Addresses = new List<string> { "Krakowska 123, 00-111 Warszawa" }
            };


            var p2 = (Person)p1.Clone();
            p2.Name = "Ewa Ewowska";
            p2.Addresses.Clear();

            Display(p1);
            Display(p2);
            p2.IdInfo.IdNumber = Guid.NewGuid();
            Display(p1);
            Display(p2);
        }

        public static void Display(Person person)
        {
            Console.WriteLine(JsonConvert.SerializeObject(person));
        }
    }
}
