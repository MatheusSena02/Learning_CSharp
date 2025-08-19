using System;

namespace DadosPessoais
{
    public class Pessoa 
    {
        public static int IdadeMinima;
        public string? Nome;
        public int Idade;

        public Pessoa(string nome, int idade)
        {
            Console.WriteLine("Executando...");
            Nome = nome;
            Idade = idade;
        }

        public Pessoa()
        {

        }

        static Pessoa()
        {
            Console.WriteLine("\nExecutando estático");
            Console.WriteLine("\nInicializando...");
            IdadeMinima = 18;
        }
    }

}
