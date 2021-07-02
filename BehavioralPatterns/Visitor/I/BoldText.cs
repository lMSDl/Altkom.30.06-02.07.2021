using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Visitor.I
{
    public class BoldText : IElement
    {
        public string Bold { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        //public string ToHtml()
        //{
        //    return $"<b>{Bold}</b>";
        //}
    }
}
