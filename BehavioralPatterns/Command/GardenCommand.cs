using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Command
{
    public class GardenCommand : ICommand
    {
        private Garden _garden;
        private string _plant;
        private GardenActions _action;

        public GardenCommand(Garden garden, string plant, GardenActions action)
        {
            _garden = garden;
            _plant = plant;
            _action = action;
        }

        public bool Execute()
        {
            switch (_action)
            {
                case GardenActions.Plant:
                    return _garden.Plant(_plant);
                case GardenActions.Remove:
                    return _garden.Remove(_plant);
            }
            return false;
        }

        public void Undo()
        {
            switch (_action)
            {
                case GardenActions.Plant:
                    _garden.Remove(_plant);
                    break;
                case GardenActions.Remove:
                    _garden.Plant(_plant);
                    break;
            }
        }
    }
}
