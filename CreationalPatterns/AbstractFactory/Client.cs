using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.CreationalPatterns.AbstractFactory
{
    public class Client
    {
        public static void Execute()
        {
            Order order;
            Console.WriteLine("\r\n------------This is HONDA Car Factory----------------");
            order = new Order(new HondaFactory(), "sedan", "compact");
            Console.WriteLine("\r\n Manufactureing " + order.ManufacturedCarName() + " as compact Sedan");

            order = new Order(new HondaFactory(), "sedan", "full");
            Console.WriteLine("\r\n Manufactureing " + order.ManufacturedCarName() + " as full Sedan");

            Console.WriteLine("\r\n\r\n------------This is TOYOTA Car Factory----------------");
            order = new Order(new ToyotaFactory(), "sedan", "compact");
            Console.WriteLine("\r\n Manufactureing " + order.ManufacturedCarName() + " as compact Sedan");

            order = new Order(new ToyotaFactory(), "sedan", "full");
            Console.WriteLine("\r\n Manufactureing " + order.ManufacturedCarName() + " as full Sedan");
            Console.ReadLine();
        }
    }
}
