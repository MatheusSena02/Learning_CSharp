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
        public void ExibirInformacoes(Carro veiculo)
        {
            Console.WriteLine($"Modelo : {veiculo.modelo}");
            Console.WriteLine($"Montadora: {veiculo.montadora}");
            Console.WriteLine($"Marca : {veiculo.marca}");
            Console.WriteLine($"Ano : {veiculo.ano}");
            Console.WriteLine($"Potência : {veiculo.potencia}");
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
    }
}



