using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.State
{
    public abstract class State : IState
    {
        private CoffeeMachine coffeeMachine;

        public CoffeeMachine CoffeeMachine
        {
            get => coffeeMachine;
            set
            {
                coffeeMachine = value;
                if (coffeeMachine != null)
                    Init();
            }
        }

        protected abstract void Init();
        public abstract void LargeCoffee();
        public abstract void SmallCoffee();
    }
}
