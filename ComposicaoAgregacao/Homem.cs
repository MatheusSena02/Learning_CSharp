using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoAgregacao
{
    public class Homem : Animal
    {
        private readonly ComportamentoAndar _comportamentoAndar;
        //Propriedade é privada e somente leitura, para não poder ser alterada após receber a instância no construtor
        public Homem(ComportamentoAndar comportamento)
        {
            _comportamentoAndar = comportamento;
        }

        public void Locomocao()
        {
            Console.WriteLine(nameof(Homem));   //Exibição do nome da classe
            _comportamentoAndar.Andar();
        }
    }
}
