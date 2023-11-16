using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio6
{
    internal abstract class Animal
    {
        public string name { get; set; }
        public int age { get; set; }

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void Speak()
        {
            Console.WriteLine("The animal is speaking");
        }
    }
}
