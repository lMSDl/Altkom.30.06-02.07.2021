using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.CreationalPatterns.AbstractFactory
{
    public class Order
    {
        private readonly ICar _car;

        public Order(ICarFactory factory, string type, string segment)
        {
            switch (type)
            {
                case "sedan":
                    _car = factory.ManufactureSedan(segment);
                    break;

                case "suv":
                    _car = factory.ManufactureSuv(segment);
                    break;
            }
        }

        public string ManufacturedCarName()
        {
            return _car.Name();
        }
    }
}
