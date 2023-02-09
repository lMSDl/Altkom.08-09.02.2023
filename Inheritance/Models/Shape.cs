using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    //klasa abstrakcyjna - baza dla innych klas, nie można utworzyć jej instancji
    //każda klasa dziedziczy niejawnie po klasie Object
    public abstract class Shape /*: Object*/
    {
        private string _name;

        public Shape(string name)
        {
            _name = name;
        }

        //metoda abstrakcyjna - nie posiada ciałą i MUSI mieć implenetację w klasach pochodnych
        //Jeśli klasa posiada metodę abstrakcyjną to ta klasa musi być też abstrakcyjna
        public abstract void SomeAbstractMethod();

        public override string ToString()
        {
            return _name;
        }
    }
}
