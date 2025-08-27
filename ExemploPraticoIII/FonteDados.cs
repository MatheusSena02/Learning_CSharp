using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPraticoIII
{
    public class FonteDados
    {
        public static List<Aluno> GetAlunos()
        {
            //Declara uma lista de objetos do tipo Aluno
            List<Aluno> alunos = new()
            {
                  new Aluno {Nome = "Maria", Nota = 8.75},
                  new Aluno {Nome = "Manoel", Nota = 6.95},
                  new Aluno {Nome = "Amanda", Nota = 7.25},
                  new Aluno {Nome = "Carlos", Nota = 6.55},
                  new Aluno {Nome = "Jaime", Nota = 8.50},
                  new Aluno {Nome = "Debora", Nota = 5.95},
                  new Aluno {Nome = "Alicia", Nota = 9.25},
                  new Aluno {Nome = "Sandra", Nota = 5.55},
                  new Aluno {Nome = "Marta", Nota = 7.85},
                  new Aluno {Nome = "Sueli", Nota = 9.15},
            };

            return alunos;
            //Retorna a lista do tipo ALuno de objetos criados
        }

        public static void ExibeAlunos(IEnumerable<Aluno> lista)
        {
            var somaNotas = 0.0; 
            Console.WriteLine("Relação de Alunos : ");
            foreach(var item in lista)
            {
                Console.WriteLine($"\nNome: {item.Nome}\tNota: {item.Nota}");
                Console.Write("__________________________");
                somaNotas += item.Nota;
            }
            Console.WriteLine($"\nMédia das Notas dos Alunos: {(somaNotas / lista.Count())}");
            Console.Write("__________________________\n");
            Console.WriteLine($"Quantidade de Alunos: {lista.Count()}");

        }

        public static void AdicionaAluno(List <Aluno> lista)
        {
            Console.Write("\nDigite o nome do novo aluno: ");
            string? novoAluno = Console.ReadLine();
            Console.Write("Digite a nota do novo aluno: ");
            double novaNota = Convert.ToDouble(Console.ReadLine());
            Aluno alunoNovo  = new Aluno { Nome = novoAluno, Nota = novaNota };
            lista.Add(alunoNovo);
            Console.WriteLine("\nOperação realizada com sucesso");

        }

        public static void BuscaAluno(List<Aluno> lista)
        {
            Console.Write("\nDigite o nome do aluno que deseja buscar: ");
            string? nomeBusca = Console.ReadLine();
            int resultadoBusca = lista.FindIndex(n => n.Nome.Contains(nomeBusca));
            if(resultadoBusca != -1)
            {
                Console.WriteLine($"{nomeBusca} está presente na lista");
                Console.WriteLine($"Posição na lista: {resultadoBusca}");
                Console.Write($"Deseja remover {nomeBusca}? (S/N) ");
                char? escolhaUsuario = Convert.ToChar(Console.ReadLine());
                if (escolhaUsuario == 'S' || escolhaUsuario == 's')
                {
                    lista.RemoveAt(resultadoBusca);
                    Console.WriteLine("Remoção concluída com sucesso");
                }
            }
        }

        public static void AnalisaNotas(List<Aluno> lista)
        {
            Console.WriteLine("Alunos que obtiveram nota maior que 8 : ");
            foreach(var item in lista)
            {
                if(item.Nota >= 8)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }
    }
}
