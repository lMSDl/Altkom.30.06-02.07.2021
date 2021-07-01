using System;

namespace WPCSharp.BehavioralPatterns.ChainOfResponsibility.II
{
    public class Button : Component
    {
        public Func<bool> Func { get; set; }

        public override void Click(bool handled)
        {
            if (handled)
                base.Click(true);
            else
                base.Click(Func?.Invoke() ?? false);
        }
    }
}
