using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.State
{
    public class HeatingUpState : State
    {
        public override void LargeCoffee()
        {
            Console.WriteLine("HeatingUpState: I am heating up!");
        }

        public override void SmallCoffee()
        {
            Console.WriteLine("HeatingUpState: I am heating up!");
        }

        protected override void Init()
        {
            Task.Delay(TimeSpan.FromSeconds(5)).ContinueWith(x => CoffeeMachine.State = new IdleState());
        }
    }
}
