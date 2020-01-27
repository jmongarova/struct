using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4._1
{
    struct NoteBook
    {
        public string model;
        public string manufacturer;
        public double price;
        public NoteBook(string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Model: {model}  Manufacture: {manufacturer} Price {price}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NoteBook thing_one = new NoteBook("HP Notebook 15-ra047ur", "China", 4999);
            thing_one.DisplayInfo();

            NoteBook thing_too;
            thing_too.model = "HP 15-dw0022ur";
            thing_too.manufacturer = "China";
            thing_too.price= 10399;
            thing_too.DisplayInfo();

            Console.ReadKey();
        }
    }
}
