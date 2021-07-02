using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Visitor.I
{
    public class PlainText : IElement
    {
        public string Plain { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        //public string ToHtml()
        //{
        //    return Plain;
        //}
    }
}
