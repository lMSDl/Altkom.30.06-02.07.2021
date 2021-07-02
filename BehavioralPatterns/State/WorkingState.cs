using System;
using System.Threading;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.State
{
    public class WorkingState : State
    {
        private int _time;

        public WorkingState(int time)
        {
            this._time = time;
        }

        public override void LargeCoffee()
        {
            _cancellationTokenSource.Cancel();
            Console.WriteLine("WorkingState: process cancelled");
        }

        public override void SmallCoffee()
        {
            _cancellationTokenSource.Cancel();
            Console.WriteLine("WorkingState: process cancelled");
        }

        private CancellationTokenSource _cancellationTokenSource;
        protected override void Init()
        {
            _cancellationTokenSource = new CancellationTokenSource();
            Task.Delay(TimeSpan.FromSeconds(_time), _cancellationTokenSource.Token)
                .ContinueWith(x =>
                {
                    CoffeeMachine.State = new IdleState();
                    _cancellationTokenSource.Dispose();
                });
        }
    }
}