using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia1
{
    class Aguila : AnimalSalvaje, Flyable
    {
        public string volar()
        {
            return "el aguila vuela";
        }
    }
}
