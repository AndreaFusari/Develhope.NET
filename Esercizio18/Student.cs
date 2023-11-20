using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio18
{
    internal class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(string name , int grade)
        {
            this.Name = name;
            this.Grade = grade; 
        }
        public override string ToString()
        {
            return $"{Name} , voto : {Grade}";
        }
    }
}
