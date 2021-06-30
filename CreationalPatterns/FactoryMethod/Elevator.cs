using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.CreationalPatterns.FactoryMethod
{
    public class Elevator
    {
        private readonly Dictionary<string, IElevatorOperation> _operations = new Dictionary<string, IElevatorOperation>();

        public void Execute(IElevatorOperation command, int floor)
        {
            command?.Operate(floor);
        }
        public void Execute(string command, int floor)
        {
            CreateOperation(command)?.Operate(floor);
        }


        public IElevatorOperation CreateOperation(string operation)
        {
            if (!_operations.TryGetValue(operation, out var elevatorOperation))
            {
                switch (nameof(Elevator) + operation)
                {
                    case nameof(ElevatorDown):
                        elevatorOperation = new ElevatorDown();
                        break;
                    case nameof(ElevatorUp):
                        elevatorOperation = new ElevatorUp();
                        break;
                    default:
                        return null;
                }
                //elevatorOperation = (IElevatorOperation)Activator.CreateInstance(GetType().Assembly.GetType(typeof(IElevatorOperation).Namespace + "." + nameof(Elevator) + operation));
                _operations[operation] = elevatorOperation;
            }

            return elevatorOperation;
        }
    }
}
