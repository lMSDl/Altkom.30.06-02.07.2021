using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.Flyweight
{
    public class Client
    {
        public static void Execute()
        {
            var factory = new FlyweightFactory(
                new CarFlyweight { Company = "Chevrolet", Model = "Camaro2018", Color = "Pink" },
                new CarFlyweight { Company = "Mercedes Benz", Model = "C300", Color = "Black" },
                new CarFlyweight { Company = "Mercedes Benz", Model = "C500", Color = "Red" },
                new CarFlyweight { Company = "BMW", Model = "M5", Color = "Red" },
                new CarFlyweight { Company = "BMW", Model = "X6", Color = "White" }
            );


            factory.Show();

            var a = Add(factory, new Car
            {
                Number = "CLS221",
                Owner = "Ewa Ewowska",
                Color = "Red",
                Company = "BMW",
                Model = "X5"
            }) ;

            var b = Add(factory, new Car
            {
                Number = "LLAP224",
                Owner = "Monika Monikowska",
                Color = "Red",
                Company = "BMW",
                Model = "X5"
            });

            factory.Show();

            var flyweight = new CarFlyweight
            {
                Model = a.Model,
                Company = a.Company,
                Color = "Black"
            };
            a.CarFlyweight = factory.GetFlyweight(flyweight);

            a.CarFlyweight.SomeOperation(a);
            b.CarFlyweight.SomeOperation(b);

            factory.Show();
        }

        static Car Add(FlyweightFactory factory, Car car)
        {
            Console.WriteLine("\nClient: Adding a car to database.");

            var flyweight = factory.GetFlyweight(car.CarFlyweight);
            car.CarFlyweight = flyweight;

            flyweight.SomeOperation(car);

            return car;
        }
    }
}
