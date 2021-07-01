using System.Collections.Generic;
using System.Linq;

namespace WPCSharp.BehavioralPatterns.Command
{
    internal class CommandsInvoker
    {
        private static readonly Stack<ICommand> Commands = new Stack<ICommand>();
        private GardenCommand _command;

        public CommandsInvoker(GardenCommand command)
        {
            _command = command;
        }

        public void Invoke()
        {
            if(_command.Execute())
                Commands.Push(_command);
        }

        public static void Undo()
        {
            if(Commands.Any())
            {
                var lastCommand = Commands.Pop();
                lastCommand.Undo();
            }
        }
    }
}