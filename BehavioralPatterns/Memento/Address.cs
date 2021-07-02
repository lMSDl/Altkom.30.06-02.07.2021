using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.BehavioralPatterns.Memento
{
    public class Address : ICloneable
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
