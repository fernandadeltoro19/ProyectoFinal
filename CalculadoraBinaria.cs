using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class CalculadoraBinaria : Calculadora
    {
        public string Sumar(int a, int b)
        {
          
            int suma = base.Sumar(a, b);
            string resultado = "";

            resultado = Convert.ToString(suma, 2);
            return resultado;
        }
      
    }
}

