using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.Manuf = "TТИип";
            notebook.Model = "Учебный ПК";
            notebook.Price = 200;
            Console.WriteLine(notebook.ToString());
            Console.ReadKey();
        }
    }
}
