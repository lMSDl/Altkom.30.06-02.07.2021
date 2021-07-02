using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Visitor.I
{
    public interface IVisitor
    {
        void Visit(PlainText element);
        void Visit(BoldText element);
        void Visit(Hyperlink element);
    }
}
