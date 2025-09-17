using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Calculadora
    {
        public static float Somar(float x, float y)
        {
            return x + y;
        }
        public static float Multiplicar(float x, float y)
        {
            return x * y;
        }
        public static float Subtrair(float x, float y)
        {
            return x - y;
        }
        public static float Dividir(float x, float y)
        {
            return x / y;
        }
    }
}
