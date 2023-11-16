using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio6
{
    internal class Bird : Animal
    {
        public override void Speak()
        {
            Console.WriteLine($"The bird is chirping");

        }
    }
}
