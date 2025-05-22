using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43._2
{
    struct Notebook
    {
        private string model;
        private string manuf;
        private double price;

        public string Model { get => model; set => model = value; }
        public string Manuf { get => manuf; set => manuf = value; }
        public double Price { get => price; set => price = value; }

        public Notebook(string model, string manuf, double price) : this()
        {
            Model = model;
            Manuf = manuf;
            Price = price;
        }

        public override string ToString() => $"Модель:{Model}" +
            $" Производитель:{Manuf}" +
            $" Цена:{Price}$";
    }
}
