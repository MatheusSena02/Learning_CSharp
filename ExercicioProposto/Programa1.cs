using System;

namespace Programas
{
    interface IVeiculo
    {
        void Dirigir();

        bool Abastecer();
    }

    public class Carro : IVeiculo
    {
        protected int quantidadeInicialGasolina;

        public Carro(int quantidade)
        {
            quantidadeInicialGasolina = quantidade;
        }

        public void Dirigir()
        {
            if(quantidadeInicialGasolina > 0)
            {
                Console.WriteLine("Dirigindo o carro...");
            }
            else
            {
                Console.WriteLine("Sem gasolina...");
                Abastecer();
            }
            
        }

        public bool Abastecer()
        {
            Console.Write("Digite a quantidade de gasolina que deseja abastecer: ");
            int quantidadeAbastecer = Convert.ToInt32(Console.ReadLine());
            quantidadeInicialGasolina += quantidadeAbastecer;
            if(quantidadeInicialGasolina > 0)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public int ExibirGasolina()
        {
            return quantidadeInicialGasolina;
        }
    }
}