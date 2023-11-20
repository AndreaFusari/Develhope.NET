using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio14
{
    internal class TrainStation
    {
        
        public string Name { get; set; }
        public string Address { get; set; }

        public TrainStation(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }
        public override string ToString()
        {
            return $"{Name}, {Address}";
        }
    }
    
    
}
