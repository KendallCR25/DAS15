using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Calculadora
    {
              
        public int CalcularFibonacci(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            else
                return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
        }

        public List<int> CalcularFibonacciDeLista(List<int> lista)
        {
            List<int> resultado = new List<int>();

            foreach (int i in lista)
            {
                resultado.Add(CalcularFibonacci(i));
            }
            return resultado;
        }
    }


