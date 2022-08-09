using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicavehiculos
{
    class Vehiculo
    {

        //CONSTRUCTOR DE CHASIS.
        public Vehiculo()
        {
            Chasis = new Chasis();
        }
        //
        private string ruedas;
        private string motor;
        private string color;
        private int consumoenlitros;

        public string Color { get; set; }
        public string Ruedas { get; set; }


        //asociacion de relacion composicion.
        public Chasis Chasis { get;}

        //relacion de tipo agregacion.
        public Motor Motor { get; set; }
        //public int Consumoenlitros { get; set; }
    }
}
