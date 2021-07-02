using System;

namespace WPCSharp.BehavioralPatterns.State
{
    public class IdleState : State
    {
        public override void LargeCoffee()
        {
            Console.WriteLine("IdleState: make large coffee");
            CoffeeMachine.State = new WorkingState(8);
        }

        public override void SmallCoffee()
        {
            Console.WriteLine("IdleState: make small coffee");
            CoffeeMachine.State = new WorkingState(5);
        }

        protected override void Init()
        {
        }
    }
}