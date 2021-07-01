using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.PrivateClassData
{
    public class ClassData
    {
        private string _a;
        private int _b;
        private float _c;

        public ClassData(string a, int b, float c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public string GetA()
        {
            return _a;
        }

        public int GetB()
        {
            return _b;
        }

        public float GetC()
        {
            return _c;
        }
    }
}
