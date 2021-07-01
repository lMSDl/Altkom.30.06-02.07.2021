using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Command
{
    public interface ICommand
    {
        bool Execute();
        void Undo();
    }
}
