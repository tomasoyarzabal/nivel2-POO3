﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia1
{
    class Gato : AnimalDomestico
    {
        public override string comunicarse()
        {
            return "miau... miau...";
        }
    }
}
