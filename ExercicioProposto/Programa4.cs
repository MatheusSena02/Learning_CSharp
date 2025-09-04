using System;

namespace Programas
{
    public class Pessoas
    {
        protected string? Nome;

        public Pessoas()
        {
            Console.Write("Digite o nome da pessoa: ");
            Nome = Console.ReadLine(); 
        }

        public static void  ExibirNomes(Pessoas[] nomes)
        {
            for(int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"{i+1}° Pessoa: {nomes[i].Nome}");   
            }
        }
    }
}
