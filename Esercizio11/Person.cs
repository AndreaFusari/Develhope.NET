using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio11
{
    internal class Person
    {
       

        public int Age { get; set; }
        public string Name { get; set; }

        public Person(int Age, string Name)
        {
            this.Age = Age;
            this.Name = Name;
        }
        public override string ToString()
        {
            return $"Name:{Name} Age:{Age} ";
        }

    }
}
