using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class AgregarDatos
    {
        List<int> lista = new List<int>();
        public void agregaLista(int numero){
            lista.Add(numero);
        }

        public int ObtenerCantidad()
        {
            int cantidad = 0;
            foreach (int element in lista)
            {
                cantidad++;
            }
            return cantidad;
        }
    }

