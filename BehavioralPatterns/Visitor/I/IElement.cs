using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Visitor.I
{
    public interface IElement
    {
        //string ToHtml();
        void Accept(IVisitor visitor);
    }
}
