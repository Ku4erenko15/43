using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43
{
    struct MyStruct
    {
        private string change;

        public string Change { get => change; set => change = value; }

        public MyStruct(string change) : this()
        {
            Change = change;
        }
    }
}
