using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Point : Shape1D
    {
        public Point() : base("Punkt", 1)
        {

        }

        //override - nadpisujemy metodę z klasy bazowej
        public override void SomeAbstractMethod()
        {
            Console.WriteLine("Wersja metody z klasy Point");
        }
    }
}
