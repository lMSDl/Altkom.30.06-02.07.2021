using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.State
{
    public class Client
    {
        public static void Execute()
        {
            var coffeeMachine = new CoffeeMachine();

            Task.Delay(TimeSpan.FromSeconds(1)).ContinueWith(x => coffeeMachine.MakeLarge());

            Task.Delay(TimeSpan.FromSeconds(7)).ContinueWith(x => coffeeMachine.MakeLarge());
            Task.Delay(TimeSpan.FromSeconds(9)).ContinueWith(x => coffeeMachine.MakeSmall());

            Task.Delay(TimeSpan.FromSeconds(12)).ContinueWith(x => coffeeMachine.MakeSmall());

            Console.ReadLine();
        }
    }
}
