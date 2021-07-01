using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Command
{
    public class Client
    {
        public static void Execute()
        {
            var garden = new Garden(10);

            var command1 = new GardenCommand(garden, "tree", GardenActions.Plant);
            var command2 = new GardenCommand(garden, "tree", GardenActions.Remove);
            var command3 = new GardenCommand(garden, "sunflower", GardenActions.Plant);
            var command4 = new GardenCommand(garden, "sunflower", GardenActions.Remove);

            var plantTreeButton = new CommandsInvoker(command1);
            var removeTreeButton = new CommandsInvoker(command2);
            var plantSunflowerButton = new CommandsInvoker(command3);
            var removeSunflowerButton = new CommandsInvoker(command4);

            Console.WriteLine(garden);
            plantTreeButton.Invoke();
            plantTreeButton.Invoke();
            plantSunflowerButton.Invoke();
            plantSunflowerButton.Invoke();
            plantSunflowerButton.Invoke();
            Console.WriteLine(garden);


            removeTreeButton.Invoke();
            removeTreeButton.Invoke();
            removeTreeButton.Invoke();
            removeSunflowerButton.Invoke();
            removeSunflowerButton.Invoke();
            Console.WriteLine(garden);


            CommandsInvoker.Undo();
            CommandsInvoker.Undo();
            CommandsInvoker.Undo();
            CommandsInvoker.Undo();
            CommandsInvoker.Undo();
            Console.WriteLine(garden);
        }
    }
}
