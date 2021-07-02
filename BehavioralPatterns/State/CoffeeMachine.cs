using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.State
{
    public class CoffeeMachine
    {
        private State state;

        public State State
        {
            get => state;
            set
            {
                state = value;
                Console.WriteLine($"CoffeeMachine: Transition to {state.GetType().Name}");
                state.CoffeeMachine = this;
            }
        }

        public CoffeeMachine()
        {
            State = new HeatingUpState();
        }


        public void MakeLarge()
        {
            State.LargeCoffee();
        }
        public void MakeSmall()
        {
            State.SmallCoffee();
        }
    }
}
