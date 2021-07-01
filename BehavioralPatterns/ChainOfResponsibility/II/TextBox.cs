using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.ChainOfResponsibility.II
{
    public class TextBox : Container
    {
        public string InputText { get; set; }

        public override void Click(bool handled)
        {
            if(!handled)
                Console.WriteLine("TextBox got focus");
            base.Click(true);
        }
    }
}
