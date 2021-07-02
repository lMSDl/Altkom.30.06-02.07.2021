using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Visitor.I
{
    public class Hyperlink : IElement
    {
        public string Url { get; set; }
        public string Label { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        //public string ToHtml()
        //{
        //    return $"<a href=\"{Url}\">{Label}</a>";
        //}
    }
}
