using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoAgregacao
{
    public class Sardinha : Animal
    {
        private readonly ComportamentoNadar _comportamentoNadar;

        public Sardinha(ComportamentoNadar comportamento)
        {
            _comportamentoNadar = comportamento;
        }

        public void Locomocao()
        {
            Console.WriteLine(nameof(Sardinha));
            _comportamentoNadar.Nadar();
        }
    }
}
