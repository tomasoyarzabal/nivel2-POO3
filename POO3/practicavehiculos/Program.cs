using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicavehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto A1 = new Auto();
            ///A1.Consumoenlitros = 45;
            //Console.Write("El consumo es " + A1.Consumoenlitros);
            Auto A2 = new Auto();
            Auto A3 = new Auto();
            Auto A4 = new Auto();
            A1.Color = "rojo";
            A2.Color = "negro";
            A3.Color = "blanco";
            A4.Color = "azul";

            List<Auto> ListaAutos = new List<Auto>();
            ListaAutos.Add(A1);
            ListaAutos.Add(A2);
            ListaAutos.Add(A3);
            ListaAutos.Add(A4);

            Console.WriteLine("la cantidad de autos es de: " + ListaAutos.Count);
            Console.WriteLine("el color del auto 1 es " + ListaAutos[0].Color);
            //ListaAutos[0].Color = "amarillo";
            A2.Color ="verde";
            Console.WriteLine("el color del auto 2 es " + ListaAutos[1].Color);
            ListaAutos.Remove(A3);
            Console.WriteLine("la cantidad de autos es de: " + ListaAutos.Count);

            foreach (Auto item in ListaAutos)
            {
                Console.WriteLine("el color de los autos es: " + item.Color);
            }

            //A2.Color = Console.ReadLine();
            //Console.WriteLine("el color es " + A2.Color);

            //asociacion de relacion agregacion
            Vehiculo V1 = new Vehiculo();
            V1.Motor = new Motor ();
            //
            Console.WriteLine(V1.Chasis());
            Console.ReadKey();
        }
    }
}
