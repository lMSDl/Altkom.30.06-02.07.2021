using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Adapter.II
{
    public class Client
    {
        public static async void Execute()
        {
            IPeopleService service = new DbPeopleServiceToServiceAdapter(new DbPeopleService());
            foreach (var person in await service.GetAsync())
            {
                ToString(person);
            }

        }

        public static void ToString(IPerson person)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
