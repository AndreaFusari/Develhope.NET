using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice
{
    internal abstract class Calculator
    {
        public double result { get; set; }
        public string expression { get; set; }
        public Calculator()
        {
            this.expression = "" ;
        }
        public abstract void Calculate(string a, string b);



    }
}
