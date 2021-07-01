using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.ChainOfResponsibility.I
{
    public abstract class BaseHandler<T> where T : BaseHandler<T>
    {
        protected T Next { get; }
        public string Name { get; set; }

        public BaseHandler(T next)
        {
            Next = next;
        }
    }
}
