using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    //: - dziedziczenie
    public abstract class Shape1D : Shape
    {
        //read-only property - nie posiada settera, możliwość ustawienia wartości tylko w konstruktorze
        public int Width { get; }

        //base - wywołanie konstruktora klasy bazowej
        public Shape1D(string name, int width) : base(name)
        {
            Width = width;
        }


        //override - nadpisujemy metodę z klasy bazowej
        public override void SomeAbstractMethod()
        {
            Console.WriteLine("wersja metody z klasy Shape1D");
        }

        public override string ToString()
        {
            return $"{base.ToString()} o długości {Width}";
        }
    }
}
