using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Essa classe serve como uma base de dados para criar os objetos dos alunos

namespace ExemploPraticoIII
{
    public class Aluno
    {
        public string Nome { get; set; } = string.Empty; //Evitar o alerta do compilador
        public double Nota { get; set; }
    }
}
