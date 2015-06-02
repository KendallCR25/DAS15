using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> entrada = new List<int>();
            //entrada.Add(4);
            //entrada.Add(6);
            //entrada.Add(20);
            //entrada.Add(1);
            //entrada.Add(11);
            //entrada.Add(25);


            //Calculadora laCalculadora = new Calculadora();
            AgregarDatos test = new AgregarDatos();
            test.agregaLista(1);
            test.agregaLista(999);
            test.agregaLista(57);

            int cantidad = test.ObtenerCantidad();
            Console.WriteLine(cantidad);
            Console.ReadLine();

        //    List<int> salida = laCalculadora.CalcularFibonacciDeLista(entrada);

        //    foreach (int i in salida)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    Console.ReadLine();
        }
    }
}
