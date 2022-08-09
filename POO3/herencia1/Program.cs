using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia1
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato G1 = new Gato();
           // Console.WriteLine(G1.comunicarse());
            Perro P1 = new Perro();
            //P1.nombre = "akiles";
            //Console.WriteLine(P1.comunicarse());

            List < Animal > listaAnimales = new List<Animal>();
            listaAnimales.Add(P1);
            listaAnimales.Add(G1);
            listaAnimales.Add(new Leon());
            listaAnimales.Add(new Tigre());

            foreach (Animal item in listaAnimales)
            {
                Console.WriteLine(item.comunicarse());
            }

            //lista de animales voladores, ejemplo de intarface.
            List<Flyable> listaVoladores = new List<Flyable>();
            listaVoladores.Add(new Aguila());

            foreach (Flyable item in listaVoladores)
            {
                Console.WriteLine(item.volar());
            }
            


            //esto que acabamos de hacer con la lista y el ciclo se denomina polimorfismo.(definicion en cuaderno).

            //casteo explicito.

           // Animal a1 = P1;

            //Perro P8 = (Perro)a1;

           // Console.WriteLine(P8.nombre);

            // ejemplo de si le cambio el nombr en P8.

           // P8.nombre = "amaranta";
           // Console.WriteLine(P1.nombre);
            // la referencia al objeto es la misma y las variables apuntan todas al mismo objeto.
            

            Console.ReadKey();

        }
    }
}
