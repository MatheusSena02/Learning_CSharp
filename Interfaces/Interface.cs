using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IControle
    {
        void Desenhar();

        public void Exibir()
        {
            Console.WriteLine("Teste...");
        }
    }

  

    public class Teste : IControle
    {
        public void Desenhar()
        {
            Console.WriteLine("Desenhando...");
        }

        public void Exibir() { }
    }
}
