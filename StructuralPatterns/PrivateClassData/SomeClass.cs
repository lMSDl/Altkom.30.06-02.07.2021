using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.StructuralPatterns.PrivateClassData
{
    public class SomeClass
    {
        private ClassData _classData;
        //private string _a;
        //private int _b;
        //private float _c;

        public SomeClass(string a, int b, float c)
        {
            _classData = new ClassData(a, b, c);
        }

        public string GetA()
        {
            return _classData.GetA();
        }
        public int GetB()
        {
            return _classData.GetB();
        }
        public float GetC()
        {
            return _classData.GetC();
        }

        public void SomeFunction()
        {
            //_a = "abc";
        }
    }
}
