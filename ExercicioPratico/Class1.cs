using System;

namespace Montadora
{
    public class Carro
    {
        public string? modelo;
        public string? montadora;
        public string? marca;
        public int ano;
        public int potencia;
        int anoAtual = DateTime.Now.Year;
        public static double valorIpva;

        public Carro(string Modelo, string Montadora)
        {
            modelo = Modelo;
            montadora = Montadora;
        }
        public Carro(string modelo, string montadora, string marca, int ano, int potencia)
        {
            this.modelo = modelo;
            this.montadora = montadora;
            this.marca = marca;
            this.ano = ano;
            this.potencia = potencia;
        }

        public void Acelerar()
        {
            Console.WriteLine($"Acelerando o meu {this.marca}\n");
        }

        public void ExibirInformacoes(string modelo, string montadora, string marca, int potencia, int ano = 0)
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
        }

        public double VelocidadeMaxima(Carro veiculo)
        {
            return this.potencia * 1.75;
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
            velocidade = carro.potencia * 1.75;
            return carro.potencia += 7;
        }

        public static void ObterValorIpva()
        {
            valorIpva = 4; 
        }
    }
}



