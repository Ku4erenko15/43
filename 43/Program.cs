using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass orig = new MyClass();
            orig.Change = "Оригинал";
            Console.WriteLine(orig.Change);
            ClassTaker(orig);

            MyStruct orig2 = new MyStruct();
            orig2.Change = "Оригинал";
            Console.WriteLine($"{orig2.Change}");
            StruktTaker(orig2 );


            Console.ReadKey();
        }
        static void ClassTaker(MyClass myClass)
        {
            myClass.Change = "Изменено";
            Console.WriteLine(myClass.Change);
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.Change = "Изменено";
                Console.WriteLine(myStruct.Change);
        }
    }
}
