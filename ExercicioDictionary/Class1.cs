using System;

namespace Class1
{
    public class Aluno
    {
        private double Nota;
        private string? Nome;

        public Aluno(string? nome, int nota)
        {
            Nome = nome;
            Nota = nota;
        }

        public void ExibeNotaAluno()
        {
            Console.WriteLine($"{Nome} - {Nota}");
        }

        public static int BuscaAluno(Dictionary<int, Aluno> dict, string? nome)
        {
            foreach(var par in  dict)
            {
                if(par.Value.Nome == nome)
                {
                    return par.Key;
                }
                
            }
            return -1;
        }
    }
}
