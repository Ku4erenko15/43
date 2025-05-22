using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43
{
    internal class MyClass
    {
        private string change;

        public string Change { get => change; set => change = value; }

        public MyClass(string Change)
        {
            Change = change;
        }

        public MyClass()
        {
        }
    }
}
