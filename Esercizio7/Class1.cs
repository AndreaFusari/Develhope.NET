using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio7
{
    internal class Class1
    {
        public int Property1 { get; set; }
        protected int Property2 { get; set; }

        private int Property3;

        public void SetProperty3(int Property3)
        {
            this.Property3 = Property3;
        }
        public int GetProperty3() { return this.Property3; }



    }
}
