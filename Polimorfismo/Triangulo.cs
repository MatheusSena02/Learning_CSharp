using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Triangulo : Figura
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando um triângulo");
            base.Desenhar();
            //Executa o método da classe base
        }
    }
}
