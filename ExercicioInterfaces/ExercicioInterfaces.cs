using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioInterfaces
{
    interface ISave
    {
        void Salvar();

        void Compactar()
        {
            Console.WriteLine($"Arquivo compactado com sucesso");
        }
    }

    public abstract class ArquivoBase
    {
        public virtual void Nome(string nome) { }
    }

    public class SalvarXml : ArquivoBase, ISave
    {
        private string? NomeArquivo {  get; set; }

        public override void Nome(string nome)
        {
            NomeArquivo = nome;
        }

        public void Salvar()
        {
            Console.WriteLine($"Arquivo {NomeArquivo}.xml salvo com sucesso");
        }
    }

    public class SalvarJson : ArquivoBase, ISave
    {
        private string? NomeArquivo { get; set; }

        public override void Nome(string nome)
        {
            NomeArquivo = nome;
        }
        public void Salvar()
        {
            Console.WriteLine($"Arquivo {NomeArquivo}.json salvo com sucesso");
        }
    }

}
