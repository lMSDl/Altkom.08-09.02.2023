using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public abstract class Shape2D : Shape1D
    {
        public int Height { get; }

        public Shape2D(string name, int width, int height) : base(name, width)
        {
            Height = height;
        }

        //base - odwołanie do wersji metody z klasy bazowej
        public override string ToString()
        {
            return $"{base.ToString()} i wysokości {Height}";
        }
    }
}
