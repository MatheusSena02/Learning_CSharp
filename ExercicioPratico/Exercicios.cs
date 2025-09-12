using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPratico
{
    public class Exercicio1<T>
    {
        private T numero1;
        public T Numero1
        {
            get
            {
                return numero1;
            }
            set
            {
                numero1 = value;
            }
        }

        private T numero2;
        public T Numero2
        {
            get
            {
                return numero2;
            }
            set
            {
                numero2 = value;
            }
        }

        public void AdicionaNumeros(T Numero1, T Numero2)
        {
            numero1 = Numero1;
            numero2 = Numero2;
            Console.WriteLine($"Valores adicionados\nNúmero 1: {numero1}\nNúmero 2: {numero2}");
        }
    }

    public class Exercicio2
    {
        public List<Aluno> SetListaAlunos()
        {
            List<Aluno> listaAlunos = new List<Aluno>
            {
                new Aluno(){Nome = "Matheus", Idade = 21, Sexo = "Masculino"},
                new Aluno(){Nome = "Correia", Idade = 24, Sexo = "Masculino"},
                new Aluno(){Nome = "Pontes", Idade = 24, Sexo = "Indefinido"},
                new Aluno(){Nome = "Márica", Idade = 18, Sexo = "Feminino"},
                new Aluno(){Nome = "José", Idade = 20, Sexo = "Masculino"},
            }; 
            return listaAlunos;
        }
    }

    public class Exercicio3
    {
        private string? expressaoMatematica;
        public string? ExpressaoMatematica
        {
            get => expressaoMatematica;
            set => expressaoMatematica = value;
        }

        public Exercicio3(string? expressao)
        {
            expressaoMatematica = expressao;
        }

        public bool VericicaBalanceamento()
        {
            Stack<char> controleBalanceamento = new Stack<char>();
            for(int i = 0; i < expressaoMatematica.Length; i++)
            {
                if(controleBalanceamento.Count == 0)
                {
                    if(expressaoMatematica[i] == ')' || expressaoMatematica[i] == ']' || expressaoMatematica[i] == '}')
                    {
                        return false;
                        break;
                    }
                    else
                    {
                        if(expressaoMatematica[i] == '(' || expressaoMatematica[i] == '[' || expressaoMatematica[i] == '{')
                        {
                            controleBalanceamento.Push(expressaoMatematica[i]);
                        }else if(expressaoMatematica[i] == ')' || expressaoMatematica[i] == ']' || expressaoMatematica[i] == '}')
                        {
                            char topo = controleBalanceamento.Peek();
                            if(topo == '(' && expressaoMatematica[i] == ')')
                            {
                                controleBalanceamento.Pop();
                            }
                            if(topo == '{' && expressaoMatematica[i] == '}')
                            {
                                controleBalanceamento.Pop();
                            }
                            if(topo == '[' && expressaoMatematica[i] == ']')
                            {
                                controleBalanceamento.Pop();
                            }
                        }
                    }
                }
                else
                {
                    if (expressaoMatematica[i] == '(' || expressaoMatematica[i] == '[' || expressaoMatematica[i] == '{')
                    {
                        controleBalanceamento.Push(expressaoMatematica[i]);
                    }
                    else if (expressaoMatematica[i] == ')' || expressaoMatematica[i] == ']' || expressaoMatematica[i] == '}')
                    {
                        char topo = controleBalanceamento.Peek();
                        if (topo == '(' && expressaoMatematica[i] == ')')
                        {
                            controleBalanceamento.Pop();
                        }
                        if (topo == '{' && expressaoMatematica[i] == '}')
                        {
                            controleBalanceamento.Pop();
                        }
                        if (topo == '[' && expressaoMatematica[i] == ']')
                        {
                            controleBalanceamento.Pop();
                        }
                    }
                }
            }

            if(controleBalanceamento.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificaBalanceamentoOtimizado()
        {
            Stack<char> controleBalanceamento = new Stack<char>();

            Dictionary<char, char> mapaPares = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' },
            };

            foreach(char c in expressaoMatematica)
            {
                if (mapaPares.ContainsValue(c))
                {
                    controleBalanceamento.Push(c);
                }
                if (mapaPares.ContainsKey(c))
                {
                    if(controleBalanceamento.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        if(controleBalanceamento.Peek() == mapaPares[c])
                        {
                            controleBalanceamento.Pop();
                        }
                    }
                }
            }

            if(controleBalanceamento.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Exercicio4
    {
        public static void FilaDeImpressao(params string[] lista)
        {
            string elemento;
            Queue<string> fila = new Queue<string>(lista);
            if(fila.Count == 0)
            {
                Console.WriteLine("Nenhum documento foi encontrado");
            }
            else
            {
                for(int i = 0; i < fila.Count; i++)
                {
                    elemento = fila.Dequeue();
                    Console.WriteLine($"Documento {elemento} está sendo impresso...");
                    Thread.Sleep(3000);
                    Console.WriteLine($"{elemento} impresso com sucesso");
                    Thread.Sleep(3000);
                }
            }
        }


    }

    public class Exercicio5
    {
        public static void ReverterEImprimir<T>(T[] lista)
        {
            Console.WriteLine("\nImpressão da lista original: ");
            foreach (T t in lista)
            {
                Console.Write($"{t}, ");
            }
            Array.Reverse(lista);
            Console.WriteLine("\nImpressão da lista reversa: ");
            foreach(T t in lista)
            {
                Console.Write($"{t}, ");
            }
        }
    }
}
