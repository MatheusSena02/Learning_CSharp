using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPratico
{
    public class Aluno
    {
        private string? nome;
        public string? Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        private int idade;
        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                idade = value;
            }
        }

        private string? sexo;
        public string? Sexo
        {
            get
            {
                return sexo;
            }
            set
            {
                sexo = value;
            }
        }
    }
}
