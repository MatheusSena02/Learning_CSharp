using System;
using CarroEnum;

namespace Montadora
{
    public class Carro
    {
        public string? Modelo;
        public string? Montadora;
        public string? Marca;
        private int ano;
        public int Ano
        {
            get { return ano; }
            set { if(value < 2000)
                {
                    Ano = 2000;
                }else if (value > 2022)
                {
                    ano = 2022;
                }
                else
                {
                    ano = value;
                }
            }
        }
        public int Potencia;
        int anoAtual = DateTime.Now.Year;
        internal static double ValorIpva = 5.2;
        public int Cor;

        public Carro(string modelo, string montadora)
        {
            Modelo = modelo;
            Montadora = montadora;
        }
        public Carro(string modelo, string montadora, string marca, int ano, int potencia, int cor)
        {

            
            Modelo = modelo;
            Montadora = montadora;
            Marca = marca;
            Ano = ano;
            Potencia = potencia;
            Cor = cor;
        }

        public static int ExibirCores()
        {
            Console.WriteLine("_________________________________________________________");
            Console.WriteLine($"| {(int)Cores.Branco} - {Cores.Branco}    | {(int)Cores.Cinza} - {Cores.Cinza}   |");
            Console.WriteLine($"| {(int)Cores.Vermelho} - {Cores.Vermelho}  | {(int)Cores.Prata} - {Cores.Prata}   |");
            Console.WriteLine($"| {(int)Cores.Preto} - {Cores.Preto}      | {(int)Cores.Azul} - {Cores.Azul}    |");
            Console.WriteLine("_________________________________________________________");
            Console.Write("                 Digite a opção desejada: ");
            int selecao = Convert.ToInt32(Console.ReadLine());
            return selecao;
        }
        public void Acelerar()
        {
            Console.WriteLine($"Acelerando o meu {this.Marca}\n");
        }

        public void ExibirInformacoes(string modelo, string montadora, string marca, int potencia, int ano = 0, int cor = 0)
        {
            if (ano == 0) 
            {
                ano = anoAtual;
            }
            Console.WriteLine($"Modelo : {modelo}");
            Console.WriteLine($"Montadora: {montadora}");
            Console.WriteLine($"Marca : {marca}");
            Console.WriteLine($"Ano : {ano}");
            Console.WriteLine($"Potência : {potencia}");
            Console.WriteLine($"Cor : {(Cores)cor}");

        }

        public double VelocidadeMaxima(Carro veiculo)
        {
            return this.Potencia * 1.75;
        }

        public int AumentarPotencia(int potencia)
        {
            return potencia += 3;
        }

        public int AumentarPotencia(ref int potencia)
        {
            return potencia += 5;
        }

        public int AumentaPotenciaVelocidade(Carro carro, out double velocidade)
        {
            velocidade = carro.Potencia * 1.75;
            return carro.Potencia += 7;
        }
    }
}



