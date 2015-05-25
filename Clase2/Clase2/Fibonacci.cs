using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    class Fibonacci
    {
        public int Calcular(int numero)
        {
            int resultado;
            if (numero == 0)
            {
                return 0;
            }
            else
            {
                if (numero == 1)
                {
                    return 1;
                }
                else
                {
                    resultado = Calcular(numero - 1) + Calcular(numero - 2);
                    return (resultado);
                }
            }
            
        }
    }
}
