using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice
{
    internal class Divisione : Calculator
    {
        public override void Calculate(string a, string b)
        {
            double A = double.Parse(a);
            double B = double.Parse(b);
            result = A / B;
            expression = $"Il risultato della divisione {a} / {b} è {result}"; ;
        }
    }
}
