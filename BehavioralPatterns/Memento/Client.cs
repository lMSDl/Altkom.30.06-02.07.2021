using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Memento
{
    public static class Client
    {
        public static void Execute()
        {
            var person = new Person();
            person.Name = "Adam Adamski";
            person.BirthDate = new DateTime(1992, 1, 23);
            person.Address = new Address { City = "Warszawa", Street = "Krakowska", PostCode = "00-111" };
            Show(person);

            var caretaker = new Caretaker<Person>(person);
            //caretaker.SaveState();

            Thread.Sleep(2000);
            person.Name = "Ewa Adamska";
            Show(person);
            //caretaker.SaveState();

            Thread.Sleep(2000);
            person.Name = "Ewa Ewowska";
            Show(person);

            caretaker.RestoreTo(3);
            Show(person);

            caretaker.Undo();
            Show(person);

            caretaker.Undo();
            Show(person);


        }

        private static void Show(Person person)
        {
            Console.WriteLine(JsonConvert.SerializeObject(person));
        }
    }
}
