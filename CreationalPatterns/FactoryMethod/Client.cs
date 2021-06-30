using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.CreationalPatterns.FactoryMethod
{
    public class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();

            var action = "GoTo";
            var floor = 3;
            elevator.Execute(action, floor);
            action = "Up";
            elevator.Execute(action, floor);
            action = "Down";
            elevator.Execute(action, floor);

            //IElevatorOperation elevatorOperation = null;
            //switch (nameof(Elevator) + action)
            //{
            //    case nameof(ElevatorDown):
            //        elevatorOperation = new ElevatorDown();
            //        break;
            //    case nameof(ElevatorUp):
            //        elevatorOperation = new ElevatorUp();
            //        break;
            //}

            //IElevatorOperation elevatorOperation = elevator.CreateOperation(action);
            //if (elevatorOperation != null)
            //{
            //    elevator.Execute(elevatorOperation, floor);
            //}
        }
    }
}
