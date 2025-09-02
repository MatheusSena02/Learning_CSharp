using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca
{
    public class Conta
    {
        protected int NumeroConta { get; set; }
        protected string? NomeCliente { get; set; }

        protected virtual decimal Saldo { get; set; } = 0.0m;

        public Conta(string nome)
        {
            NomeCliente = nome;
            Random seed = new Random();
            NumeroConta = seed.Next(0000000001, 999999999);
        }

        public virtual void Depositar(decimal entrada)
        {
            if(entrada <= 0)
            {
                Console.Write("Valor digitado não válido");
            }
            else
            {
                Saldo += entrada;
                Console.WriteLine("Depósito concluído com sucesso!");
            }
        }

        public virtual void Sacar(decimal retirada)
        {
            if(retirada <= 0)
            {
                Console.WriteLine("Valor digitado não válido");
            }else if(retirada > Saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                Saldo -= retirada;
                Console.WriteLine("\nSaque concluído com sucesso!");
            }
        }

        public virtual void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {Saldo}");
        }
    }

    public class Poupanca : Conta
    {
        protected decimal saldo = 0.0m;

        public Poupanca(string nome) : base(nome)
        {
        }

        internal decimal valorJuros = 0.005m;


        protected override decimal Saldo
        {
            get { return saldo; }
            set
            {
                if(saldo < 0)
                {
                    saldo = 0;
                }
                else
                {
                    saldo = value;
                }
            }
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor + (valorJuros * valor);
            Console.WriteLine("\nDepósito concluído com sucesso!");
        }
    }

    public class Investimentos : Conta
    {
        private decimal saldo = 0.0m;
        protected override decimal Saldo
        {
            get { return saldo; }
            set
            {
                if (saldo < 0)
                {
                    saldo = 0;
                }
                else
                {
                    saldo = value;
                }
            }
        }

        internal decimal valorJuros = 0.009m;
        internal decimal valorImposto = 0.001m;

        public Investimentos(string nome) : base(nome)
        {

        }

        public override void Depositar(decimal valor)
        {
            saldo += valor + (valor* valorJuros);
            Console.WriteLine("\nDepósito concluído com sucesso!");
        }

        public new void Sacar(decimal valor)
        {
            saldo -= valor + (valor * valorImposto);
            Console.WriteLine("\nSaque concluído com sucesso!");
        }
    }

}
